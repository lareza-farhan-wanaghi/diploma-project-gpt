import os
from PIL import Image
import pathlib

mediaDirectory = os.path.join(os.getcwd(), "./")
uncompressedDirectory = "conversations"
compressedDirectory = "conversations-test"


def ConvertAllPngToWebp(source):
    renames = []
    for d, subdirs, fs in os.walk(source):
        for f in fs:
            if f.endswith(".png") or f.endswith(".jpg") or f.endswith(".jpeg"):
                oldname = os.path.join(d, f)
                newd = d.replace(uncompressedDirectory, compressedDirectory)
                newf = pathlib.Path(f).with_suffix(".jpg")
                newname = os.path.join(newd, newf)
                renames.append([newd, oldname, newname])
    for (newd, oldname, newname) in reversed(renames):
        if not os.path.exists(newname):
            os.makedirs(newd, exist_ok=True)
            image = Image.open(oldname)
            image = image.resize((image.size[0] // 2, image.size[1] // 2))
            image.convert("RGB").save(newname, format="jpeg", optimize=True, quality=20)


def ExecuteProgram():
    print("Setup frontend resources" + "." * 10)
    ConvertAllPngToWebp(os.path.join(mediaDirectory, uncompressedDirectory))
    print("Setup completed!")


ExecuteProgram()
