using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using Domain;
namespace ObjectMapper
{
    public static class AnnouncementMapper
    {
        public static AnnouncementViewModel ToViewModel(this Announcemnets an)
        {
            return null;
        }
        public static Announcemnets ToDomainModel(this AnnouncementViewModel avm)
        {
            Announcemnets ans = new Announcemnets();

            ans.Id = avm.Id;
            ans.Title = avm.Title;
            ans.VisibleDate = avm.VisibleDate.ToString();
            ans.ExpDate = avm.ExpiaryDate.ToString();
            ans.CreatedDate = DateTime.Now.ToLongDateString();
            ans.PictureUrl = avm.PictureUrl;
            ans.Text = avm.ContentDescription;
            return ans;
        }
    }
}
