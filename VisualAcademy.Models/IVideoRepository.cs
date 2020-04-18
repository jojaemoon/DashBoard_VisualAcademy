using System.Collections.Generic;
using System.Text;

namespace VisualAcademy.Models
{
    /// <summary>
    /// [3] 인터페이스: Videos 테이블에 대한 CRUD API 명세서 작성
    /// </summary>
    public interface IVideoRepository
    {
        Video AddVideo(Video model);    // 입력: T Add(T model);
        List<Video> GetVideos();        // 출력: List<T> GetAll();
        Video GetVideoById(int id);     // 상세: GetByID(int id);
        Video UpdateVideo(Video model); // 수정: T Edit(T model);
        void RemoveVideo(int id);       // 삭제: void Delete(int id);

        // 추가: 검색, 페이징, 소팅, ...
    }
}
