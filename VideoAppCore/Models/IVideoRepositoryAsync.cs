using System.Collections.Generic;
using System.Threading.Tasks;

namespace VideoAppCore.Models
{
    /// <summary>
    /// [3][2] 인터페이스(비동기방식): Videos 테이블에 대한 CRUD API 명세서 작성
    /// </summary>
    public interface IVideoRepositoryAsync
    {
        Task<Video> AddVideoAsync(Video model);    // 입력: T Add(T model);
        Task<List<Video>> GetVideosAsync();        // 출력: List<T> GetAll();
        Task<Video> GetVideoByIdAsync(int id);     // 상세: GetByID(int id);
        Task<Video> UpdateVideoAsync(Video model); // 수정: T Edit(T model);
        Task RemoveVideoAsync(int id);       // 삭제: void Delete(int id);

        // 추가: 검색, 페이징, 소팅, ...
    }

}
