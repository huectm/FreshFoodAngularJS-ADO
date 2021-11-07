using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc.Models;
using mvc.DAO;

namespace mvc.Buss
{
    public class CategoryBus
    {
        CategoryDAO sp = new CategoryDAO();
        public List<LoaiSP> GetCategory()
        {
            return sp.GetCategory();

        }
    }
}