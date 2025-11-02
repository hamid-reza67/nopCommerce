using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.RedMoon.Core;

public class RedMoonCorePlugin : BasePlugin
{
    public bool HideInWidgetList => false;

    private readonly IWebHelper _webHelper;
    private readonly ISettingService _settingService;

    public RedMoonCorePlugin(IWebHelper webHelper, ISettingService settingService)
    {
        _webHelper = webHelper;
        _settingService = settingService;
    }

    /// <summary>
    /// Gets a configuration page URL
    /// </summary>
    public override string GetConfigurationPageUrl()
    {
        return $"{_webHelper.GetStoreLocation()}Admin/RedMoonCorePlugin/Configure";
    }


    public Type GetWidgetViewComponent(string widgetZone)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets widget zones where this widget should be rendered
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation
    /// The task result contains the widget zones
    /// </returns>
    //public Task<IList<string>> GetWidgetZonesAsync()
    //{
    //}

    public override async Task InstallAsync()
    {
        await base.InstallAsync();
    }

    public override async Task UninstallAsync()
    {
        await base.UninstallAsync();
    }
}
