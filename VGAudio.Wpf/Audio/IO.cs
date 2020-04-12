﻿using System.IO;
using VGAudio.Containers;
using VGAudio.Formats;

namespace VGAudio.Wpf.Audio
{
    public static class IO
    {
        public static IAudioFormat OpenFile(string path)
        {
            FileType type = AudioInfo.GetFileTypeFromName(path);
            IAudioReader reader = AudioInfo.Containers[type].GetReader();

            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return reader.ReadFormat(stream);
            }
        }

        public static void SaveFile(AudioData audio, string path)
        {

        }
    }
}