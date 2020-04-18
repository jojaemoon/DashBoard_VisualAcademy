﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAcademy.Models
{
    /// <summary>
    /// [2] 모델 클래스: Video 모델 클래스 = Videos 테이블과 일대일로 매핑
    /// Videos => Video, VideoModel, VideoViewModel, VideoBase, VideoDto, VideoEntity, ...
    /// </summary>
    public class Video
    {
        /// <summary>
        /// 일련번호
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 등록일
        /// </summary>
        public DateTimeOffset Create { get; set; }
        /// <summary>
        /// 동영상 제목
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 동영상 제공경로
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 동영상 작성자
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 회사
        /// </summary>
        public string Company { get; set; }
    }
}
