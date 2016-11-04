using AutoMapper;
using GuardianClassLib.Models.MainDb.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.HELPER.ModelConvert
{
    public class ActivityProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ActivityProfile";
            }
        }

        protected override void Configure()
        {
            var convert = new ActivityConvert();
            CreateMap<RequestActivity, ResponseActivity>().ConvertUsing(convert);
        }
    }

    public class ActivityConvert : ITypeConverter<RequestActivity, ResponseActivity>
    {

        public ResponseActivity Convert(RequestActivity l, ResponseActivity destination, ResolutionContext context)
        {

            return new ResponseActivity
            {
                PkId = l.ActiveID.ToString(),
                Type = EnumHelper.GetValueFromDescription<EnumActivityType>(l.TypeName),
                Category = l.ActiveName,
                Thumb = l.Icon,
                Title = l.ActiveTitle,
                StartTime = l.BeginTime,
                EndTime = l.EndTime,
                Disabled = l.Disabled,
                Content = l.ActiveContents,
                ActivityMedias = SetArg(l.PhotoAddress),
                GoodsId = l.CommodityID
            };
        }
        private List<ActivityMedias> SetArg(string imgs)
        {
            var list = new List<ActivityMedias>();
            if (imgs == null || !imgs.Contains(".")) return list;
            var simgs = imgs.Split(',');
            foreach (var img in simgs)
            {
                if (string.IsNullOrEmpty(img)) continue;
                list.Add(new ActivityMedias { Type = EnumActivityMediasType.PICTURE, Content = img });
            }
            return list;
        }
    }
}
