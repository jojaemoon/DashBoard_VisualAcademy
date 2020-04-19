using System;

namespace VisualAcademy.Models
{
    /// <summary>
    /// AuditableBase 클래스: 레코드에 대한 상태 추적을 위한 4개의 속성 제공
    /// Dul.dll -> Dul.Domain.Common.AuditableBase.cs
    /// </summary>
    public class AuditableBase
    {
        /// <summary>
        /// 등록자: CreatedBy, Creator
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// 등록일
        /// </summary>
        //public DateTimeOffset Created { get; set; }
        public DateTime Created { get; set; }

        /// <summary>
        ///수정자: LastModifiedBy, ModifiedBy
        /// </summary>
        public DateTime ModifiedBy { get; set; }

        /// <summary>
        /// 수정일
        /// </summary>
        public DateTime? Modified { get; set; }
    }
}
