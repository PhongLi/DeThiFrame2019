using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaoTriThietBi.Models
{
    public class CanHoModel
    {
        [Display(Name = "Mã căn hộ")]
        public string MaCanHo { get; set; }
        [Display(Name = "Tên chủ hộ")]
        public string TenChuHo { get; set; }

    }
}
