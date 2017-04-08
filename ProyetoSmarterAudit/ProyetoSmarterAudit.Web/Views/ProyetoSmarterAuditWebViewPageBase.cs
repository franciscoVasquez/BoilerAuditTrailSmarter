using Abp.Web.Mvc.Views;

namespace ProyetoSmarterAudit.Web.Views
{
    public abstract class ProyetoSmarterAuditWebViewPageBase : ProyetoSmarterAuditWebViewPageBase<dynamic>
    {

    }

    public abstract class ProyetoSmarterAuditWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ProyetoSmarterAuditWebViewPageBase()
        {
            LocalizationSourceName = ProyetoSmarterAuditConsts.LocalizationSourceName;
        }
    }
}