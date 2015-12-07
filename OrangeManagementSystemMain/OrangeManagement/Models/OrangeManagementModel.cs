//-----------------------------------------------【Function Indroduction】----------------------------------------------
//	  DBHelper：  database connected class
//    Language：  C#
//    IDE：VS2013
//    2015.10.16  Created by RaymondMG  
//---------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeManagement.Models
{
    /// <summary>
    /// 校区管理
    /// </summary>
    [Table("T_CampusModel", Schema = "dbo")]//关联数据表
    public class CampusModel
    {
        [Key]
        public int CampusId { get; set; }

        //校区名
        [Required]
        [Display(Name = "校区名称")]
        public string CampusName { get; set; }


        //校区编号
        [Required]
        [Display(Name = "校区编号")]
        public string CampusNumber { get; set; }

        //校区简介
        [Required]
        [Display(Name = "校区简介")]
        public string CampusDescribe { get; set; }

        //校区地址
        [Required]
        [Display(Name = "校区地址")]
        public string CampusAddress { get; set; }
    }

}





