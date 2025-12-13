const fs = require('fs');
const path = require('path');

// This script fixes renaming issues with pictures that come from screenshots and from messenger

const currentDir = process.cwd();

fs.readdir(currentDir, { withFileTypes: true }, (err, entries) => {
    if (err) {
        console.error(err);
        process.exit(1);
    }


    const imgFiles = [];
    const screenshotFiles = [];

    entries
        .filter(entry => entry.isFile())
        .forEach(entry => {

            // Match IPhone IMG files
            const parts = entry.name.match(/^(\d+_\d+) IMG_(\d+)(.*$)/);
            if (parts) {
                imgFiles.push({
                    name: entry.name,
                    timeStamp: parts[1],
                    imgNumber: parseInt(parts[2], 10),
                    suffix: parts[3]
                });
            }

            // Match samsung Screenshot files
            //20251112_193930 Screenshot_20230814-203817_Chrome
            const screenParts = entry.name.match(/^(\d+_\d+) Screenshot_(\d+[-_]\d+.*$)/);
            if (screenParts) {
                screenshotFiles.push({
                    name: entry.name,
                    timeStamp: screenParts[1],
                    realName: screenParts[2],
                });
            }
        });

    renameScreenshotFiles(screenshotFiles);
    

    // Rename IPhone IMG files
    renameIPhoneImportedImages(imgFiles);
});


// --------------------------------------------------------------------------------
//
// --------------------------------------------------------------------------------
function renameIPhoneImportedImages(imgFiles) {
    console.log(`Found ${imgFiles.length} IPhone files.`);
    imgFiles.sort((a, b) => {
        return a.imgNumber - b.imgNumber;
    });

    let lastGoodtimeStamp = "0000_0000";
    let badDatetimeStamp = "20251201_000000";
    let renameCount = 0;

    for (let i = 0; i < imgFiles.length; i++) {
        const file = imgFiles[i];
        //console.log(`Checking ${file.name}`);
        if (file.timeStamp > badDatetimeStamp) {
            const fixedtimeStamp = lastGoodtimeStamp.substring(0, 8) + "_000000";
            const oldName = file.name;
            const newName = `${fixedtimeStamp} IMG_${String(file.imgNumber).padStart(4, "0")}${file.suffix}`;
            file.timeStamp = fixedtimeStamp;
            fs.rename(oldName, newName, err => {
                if (err) {
                    console.error(`Failed to rename ${oldName}:`, err);
                } else {
                    console.log(`    Renamed: ${oldName} → ${newName}`);
                }
            });
            renameCount++;
        } else {
            lastGoodtimeStamp = file.timeStamp;
        }
    }

    console.log(`Renamed ${renameCount} IPhone files.`);
}

// --------------------------------------------------------------------------------
//
// --------------------------------------------------------------------------------
function renameScreenshotFiles(screenshotFiles) {
    console.log(`Found ${screenshotFiles.length} screenshot files to rename.`);
    for (let i = 0; i < screenshotFiles.length; i++) {
        const file = screenshotFiles[i];
        const oldName = file.name;
        const newName = file.realName.replace(/-/g, '_');
        fs.rename(oldName, newName, err => {
            if (err) {
                console.error(`Failed to rename ${oldName}:`, err);
            } else {
                console.log(`    Renamed: ${oldName} → ${newName}`);
            }
        });
    }
    console.log(`Renamed ${screenshotFiles.length} screenshot files.`);
}
// 2022  4001
// 2025  4002
// 2025  4003
// 2022  4004
