/* ****************************************************************************************
 * 创建日期：2016-07-14 09:27:11 
 * 由工具生成
 * ****************************************************************************************/
using System;
using System.Text;

namespace MyClassName
{
    [Serializable]
    /// <summary>
    /// Loan
    /// </summary>
    public class Loan
    {
        #region 属性
        /// <summary>
        /// 获取或设置
        /// </summary>
        public Guid  ID{ get; set; }
        /// <summary>
        /// 获取或设置
        /// </summary>
        public Guid?  Project{ get; set; }
        /// <summary>
        /// 获取或设置放款金额
        /// </summary>
        public string  LoanAmount{ get; set; }
        /// <summary>
        /// 获取或设置放款日期
        /// </summary>
        public string  LoanDate{ get; set; }
        /// <summary>
        /// 获取或设置
        /// </summary>
        public DateTime?  UPD{ get; set; }
        /// <summary>
        /// 获取或设置
        /// </summary>
        public int?  Status{ get; set; }
        #endregion
    }

	}

