using System;
using System.Collections.Generic;

namespace VideoAppCore.Models
{
    /// <summary>
    /// [4][2][1] 리포지토리 클래스(동기 방식): Micro ORM인 Dapper를 사용하여 CRUD 구현
    /// </summary>
    public class VideoRepositoryDapper : IVideoRepository
    {
        public Video AddVideo(Video model)
        {
            throw new NotImplementedException();
        }

        public Video GetVideoById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Video> GetVideos()
        {
            throw new NotImplementedException();
        }

        public void RemoveVideo(int id)
        {
            throw new NotImplementedException();
        }

        public Video UpdateVideo(Video model)
        {
            throw new NotImplementedException();
        }
    }
}
