
const childProcess = require('child_process');
const fs = require('fs');
const path = require('path');
const currentDir = process.cwd();

function getVideoMetadata(filePath) {
    return new Promise((resolve, reject) => {
        childProcess.execFile(
            "exiftool",
            [
                "-DateTimeOriginal",
                "-CreateDate",
                "-MediaCreateDate",
                "-j",               // JSON output
                filePath
            ],
            (err, stdout) => {
                if (err) reject(err);
                resolve(JSON.parse(stdout)[0]);
            }
        );
    })

}

fs.readdir(currentDir, { withFileTypes: true }, (err, entries) => {
    if (err) {
        console.error(err);
        process.exit(1);
    }

    const fileList = [];
    entries
        .filter(entry => entry.isFile())
        .forEach(async(entry) => {

            // Match IPhone IMG files
            const parts = entry.name.match(/^([0-9_ ]+)(.*$)/);
            if(!parts) {
                console.warn(`File ${entry.name} does not match expected pattern.`);
                return;
            }

            const metaData = await getVideoMetadata(entry.name);
            let realDate = undefined;
            if (metaData.MediaCreateDate && metaData.MediaCreateDate !== "0000:00:00 00:00:00") {
                realDate = metaData.MediaCreateDate.replace(/:/g, '').replace(' ', '_');
            } else if (metaData.CreateDate && metaData.CreateDate !== "0000:00:00 00:00:00") {
                realDate = metaData.CreateDate.replace(/:/g, '').replace(' ', '_');
            } else if (metaData.DateTimeOriginal && metaData.DateTimeOriginal !== "0000:00:00 00:00:00") {
                realDate = metaData.DateTimeOriginal.replace(/:/g, '').replace(' ', '_');
            }

            if(realDate) {
                const newName = realDate + " " + parts[2];
                console.log(`Renaming ${entry.name} to ${newName}`);
                fs.rename(entry.name, newName, err => {
                    if (err) {
                        console.error(`Failed to rename ${entry.name}:`, err);
                    }
                });
            }
            

        });


});