using OrchardCore.ResourceManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrchardCore.ResourceX
{
    public class ResourceManifestX : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var area = "~/libs";
            var manifest = builder.Add();

            manifest
                .DefineScript("X-jQuery")
                .SetUrl($"{area}/jquery/jquery.min.js")
                .SetCdn("https://cdn.bootcss.com/jquery/3.2.1/jquery.min.js")
                .SetVersion("3.2.1");

            manifest
                .DefineScript("X-jQuery-slimscroll")
                .SetUrl($"{area}/jquery-slimscroll/jquery.slimscroll.min.js")
                .SetCdn("https://cdn.bootcss.com/jQuery-slimScroll/1.3.8/jquery.slimscroll.min.js")
                .SetVersion("1.3.8");                           

            manifest
                .DefineScript("X-bootstrap")
                .SetDependencies("X-jQuery")
                .SetUrl($"{area}/bootstrap/js/bootstrap.min.js")
                .SetCdn("https://cdn.bootcss.com/bootstrap/3.3.7/js/bootstrap.min.js")
                .SetVersion("3.3.7");

            manifest
                .DefineStyle("X-bootstrap")
                .SetUrl($"{area}/bootstrap/css/bootstrap.min.css")
                .SetCdn("https://cdn.bootcss.com/bootstrap/3.3.7/css/bootstrap.min.css")
                .SetVersion("3.3.7");

            manifest
                .DefineStyle("X-font-awesome")
                .SetUrl($"{area}/font-awesome/css/font-awesome.min.css")
                .SetCdn("https://cdn.bootcss.com/font-awesome/4.7.0/css/font-awesome.min.css")
                .SetVersion("4.7.0");

            manifest
                .DefineStyle("X-metisMenu")
                .SetUrl($"{area}/metismenu/metisMenu.min.css")
                .SetCdn("https://cdn.bootcss.com/metisMenu/2.7.0/metisMenu.min.css")
                .SetVersion("2.7.0");

            manifest
                .DefineScript("X-metisMenu")
                .SetUrl($"{area}/metismenu/metisMenu.min.js")
                .SetCdn("https://cdn.bootcss.com/metisMenu/2.7.0/metisMenu.min.js")
                .SetVersion("2.7.0");

            manifest
                .DefineStyle("X-animate")
                .SetUrl($"{area}/animate.css/animate.min.css")
                .SetCdn("https://cdn.bootcss.com/animate.css/3.5.2/animate.min.css")
                .SetVersion("3.5.2");

            manifest
                .DefineScript("X-icheck")
                .SetUrl($"{area}/icheck/icheck.min.js")
                .SetCdn("https://cdn.bootcss.com/iCheck/1.0.2/icheck.min.js")
                .SetVersion("1.0.2");

            manifest
                .DefineStyle("X-icheck-skins-all")
                .SetUrl($"{area}/icheck/skins/all.css")
                .SetCdn("https://cdn.bootcss.com/iCheck/1.0.2/skins/all.css")
                .SetVersion("1.0.2");

            manifest
                .DefineStyle("X-bootstrap-table")
                .SetDependencies("X-bootstrap")
                .SetUrl($"{area}/bootstrap-table/bootstrap-table.min.css")
                .SetCdn("https://cdn.bootcss.com/bootstrap-table/1.11.1/bootstrap-table.min.css")
                .SetVersion("1.11.1");

            manifest
                .DefineScript("X-bootstrap-table")
                .SetDependencies("X-jQuery")
                .SetUrl($"{area}/bootstrap-table/bootstrap-table.min.js")
                .SetCdn("https://cdn.bootcss.com/bootstrap-table/1.11.1/bootstrap-table.min.js")
                .SetVersion("1.11.1");
        }
    }
}
