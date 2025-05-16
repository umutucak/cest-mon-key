#!/bin/bash

for file in *.ogg; do
  base="${file%.ogg}"
  ffmpeg -y -i "$file" -c:a libvorbis -b:a 192k "${base}_fixed.ogg"
done

