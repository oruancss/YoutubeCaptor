# <img src="https://cdn.emojidex.com/emoji/px32/YouTube.png?1512927079"> YoutubeCaptor

A simple console app to download any video from youtube.<br>
NuGet I used in this project: https://github.com/omansak/libvideo

### How does it work?

It'll download any video from youtube, you just need put the video link.
This application will download any video in 360p, sadly the API I used in this project can't download audio if the resolution is above 360p.<br>
In case you want this to download videos in highest quality, I left a comment with the variable that configs video to be downloaded in highest quality, you can use ffmpeg to download audio separated and mix them later.

### Where will videos be saved?

Inside a folder called "Downloads", you'll find it in the same folder as the .EXE<br>
Also, the downloads folder is automatically created if deleted or moved.

<b>Enjoy.</b>
