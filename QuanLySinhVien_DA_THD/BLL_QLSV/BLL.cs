using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLSV;
using System.Data;

namespace BLL_QLSV
{
    public class BLL
    {
        DAL dalSinhVien = new DAL();

        public DataSet layThongTinSV()
        {
            return dalSinhVien.layThongTinSV();
        }

        public DataTable layThongTinSV2()
        {
            return dalSinhVien.layThongTinSV2();
        }

        public void addSinhVien(SinhVien sv)
        {
            dalSinhVien.themSinhVien(sv);
        }

        public void updateSinhVien(SinhVien sv, string avlb)
        {
            dalSinhVien.suaSinhVien(sv, avlb);
        }

        public void deleteSinhVien(string id)
        {
            dalSinhVien.xoaSinhVien(id);
        }
    }
}
