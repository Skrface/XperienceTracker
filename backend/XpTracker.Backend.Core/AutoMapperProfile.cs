using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace XpTracker.Backend.Core
{
    /// <summary>
    /// Automapper profile
    /// </summary>
    public class AutoMapperProfileConfiguration : Profile
    {
        /// <summary>
        /// constructor
        /// </summary>
        public AutoMapperProfileConfiguration() : this("MyProfile")
        {
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="profileName"></param>
        protected AutoMapperProfileConfiguration(string profileName)
        : base(profileName)
        {
           // CreateMap<VmUserPost, User>()
           //     .ForMember(u => u.DisplayName, opt => opt.Ignore())
           //     .ForMember(u => u.Managee, opt => opt.Ignore())
           //     .ForMember(u => u.Manager, opt => opt.Ignore())
           //     .ForMember(u => u.DisplayName, opt => opt.Ignore());

           // CreateMap<FeedbackInquiry, VmFeedbackInquiry>()
           //     .Include<FeedbackInquiryMfc, VmFeedbackInquiry>()
           //     .Include<FeedbackInquiryMlc, VmFeedbackInquiry>()
           //     .Include<FeedbackInquiryProject, VmFeedbackInquiry>()
           //  .ForMember(dest => dest.From, opt => opt.ResolveUsing(src => new VmUser() { UPN = src.FromUpn }))
           //  .ForMember(dest => dest.CreationDate, opt => opt.ResolveUsing(src => src.CreatedDate));


           // CreateMap<VmRegisterRequestPost, DeviceRegistration>()
           //     .ForMember(dest => dest.Upn, opt => opt.Ignore());


           // CreateMap<FeedbackInquiryMlc, VmFeedbackInquiry>()
           //     .ForMember(f => f.MfcCategoryDisplaytext, opt => opt.Ignore())
           //     .ForMember(f => f.MfcCategoryId, opt => opt.Ignore())
           //      .ForMember(f => f.MfcLevel, opt => opt.UseValue<MfcLevel?>(null))
           //      .ForMember(f => f.MfcCompetencyDisplaytext, opt => opt.Ignore())
           //       .ForMember(f => f.MfcCompetencyId, opt => opt.Ignore())
           //        .ForMember(f => f.MfcFrameworkDisplaytext, opt => opt.Ignore())
           //         .ForMember(f => f.MfcFrameworkId, opt => opt.Ignore())
           //         .ForMember(f => f.ProjectName, opt => opt.Ignore());


           // CreateMap<FeedbackInquiryMfc, VmFeedbackInquiry>()
           //     .ForMember(f => f.MlcCompetencyDisplaytext, opt => opt.Ignore())
           //     .ForMember(f => f.MlcCompetencyId, opt => opt.Ignore())
           //         .ForMember(f => f.MfcLevel, opt =>
           //         {
           //             opt.MapFrom(s => s.MfcLevelId);
           //         }
           //             )
           //       .ForMember(f => f.MfcLevelDisplayText, opt => opt.Ignore())
           //        .ForMember(f => f.ProjectName, opt => opt.Ignore())
           //         .ForMember(f => f.ProjectName, opt => opt.Ignore());

           // CreateMap<FeedbackInquiryProject, VmFeedbackInquiry>()
           // .ForMember(f => f.MlcCompetencyDisplaytext, opt => opt.Ignore())
           // .ForMember(f => f.MlcCompetencyId, opt => opt.Ignore())
           //  .ForMember(f => f.MfcLevel, opt => opt.Ignore())
           //   .ForMember(f => f.MfcLevelDisplayText, opt => opt.Ignore())
           //    .ForMember(f => f.MfcCategoryDisplaytext, opt => opt.Ignore())
           //     .ForMember(f => f.MfcCategoryId, opt => opt.Ignore())
           //      .ForMember(f => f.MfcCompetencyDisplaytext, opt => opt.Ignore())
           //       .ForMember(f => f.MfcCompetencyId, opt => opt.Ignore())
           //        .ForMember(f => f.MfcFrameworkDisplaytext, opt => opt.Ignore())
           //         .ForMember(f => f.MfcFrameworkId, opt => opt.Ignore());

           // CreateMap<Feedback, VmFeedbackGet>()
           //     .ForMember(f => f.From, opt => opt.ResolveUsing(s => new VmUser() { UPN = s.FromUpn }))
           //     .ForMember(f => f.Date, opt => opt.ResolveUsing(s => s.FeedbackDate));


           // CreateMap<Recognition, VmRecognitionPost>()
           //     .ForMember(f => f.From, opt => opt.ResolveUsing(s => new VmUserPost() { UPN = s.FromUpn }));
           // CreateMap<Recognition, VmRecognitionGet>()
           //   .ForMember(f => f.From, opt => opt.ResolveUsing(s => new VmUserPost() { UPN = s.FromUpn }));


           // CreateMap<Feedback, DtoFeedbackMail>()
           //.ForMember(f => f.From, opt => opt.ResolveUsing(s => new DtoMailUser() { UPN = s.FromUpn }));



            //   CreateMap<VmAnswer, Answer>().ForMember(f => f.Id, opt => opt.MapFrom( s => s.))


        }
    }
}
