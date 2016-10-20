﻿using movie_trailers.DAL.Services;
using movie_trailers.Interfaces;

namespace movie_trailers
{
    class VideoFactory
    {
        public enum VideoTypes
        {
            Youtube,
            Vimeo
        }

        public static IVideo Get(VideoTypes type)
        {
            switch (type)
            {
                case VideoTypes.Youtube:
                    return new YoutubeTrailerService();
                case VideoTypes.Vimeo:
                    return new VimeoTrailerService();
                default:
                    return new YoutubeTrailerService();
            }
        }

    }
}