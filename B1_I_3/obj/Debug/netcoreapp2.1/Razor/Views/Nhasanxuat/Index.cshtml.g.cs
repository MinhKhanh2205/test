#pragma checksum "C:\Users\Admin\Documents\Downloads\test\Tuan 1\Lab1_2_Tuan4\B1_I_3\Views\Nhasanxuat\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "79c9097c35539b7e9c756d419566e1dff306120b3f001b0fb3c01e081394abed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nhasanxuat_Index), @"mvc.1.0.view", @"/Views/Nhasanxuat/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Nhasanxuat/Index.cshtml", typeof(AspNetCore.Views_Nhasanxuat_Index))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"79c9097c35539b7e9c756d419566e1dff306120b3f001b0fb3c01e081394abed", @"/Views/Nhasanxuat/Index.cshtml")]
    public class Views_Nhasanxuat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Documents\Downloads\test\Tuan 1\Lab1_2_Tuan4\B1_I_3\Views\Nhasanxuat\Index.cshtml"
  
    Layout = null;

#line default
#line hidden

            BeginContext(78, 302, true);
            WriteLiteral(@"<style>
    table,th,td{
        border:1px solid black;
        border-collapse:collapse;        
    }
    th,td{
        padding:15px;
    }
    th{
        text-align:center;
    }
    table{
        border-spacing:5px;
    }
</style>
<h2>Thông tin các nhà sản xuất</h2>
<p>
    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 380, "\"", 406, 1);
            WriteAttributeValue("", 387, 
#line 22 "C:\Users\Admin\Documents\Downloads\test\Tuan 1\Lab1_2_Tuan4\B1_I_3\Views\Nhasanxuat\Index.cshtml"
              Url.Action("them")

#line default
#line hidden
            , 387, 19, false);
            EndWriteAttribute();
            BeginContext(407, 137, true);
            WriteLiteral(">Thêm mới</a>\r\n</p>\r\n<table>\r\n    <tr>\r\n        <th>Tên nhà sản xuất</th>\r\n        <th>Địa chỉ</th>\r\n        <th>Tác vụ</th>\r\n    </tr>\r\n");
            EndContext();
#line 30 "C:\Users\Admin\Documents\Downloads\test\Tuan 1\Lab1_2_Tuan4\B1_I_3\Views\Nhasanxuat\Index.cshtml"
      
        foreach (var item in ViewBag.nsx)
        // foreach (var item in Model)
        {

#line default
#line hidden

            BeginContext(646, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(685, 11, false);
            Write(
#line 35 "C:\Users\Admin\Documents\Downloads\test\Tuan 1\Lab1_2_Tuan4\B1_I_3\Views\Nhasanxuat\Index.cshtml"
                     item.Tennsx

#line default
#line hidden
            );
            EndContext();
            BeginContext(696, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(724, 11, false);
            Write(
#line 36 "C:\Users\Admin\Documents\Downloads\test\Tuan 1\Lab1_2_Tuan4\B1_I_3\Views\Nhasanxuat\Index.cshtml"
                     item.Diachi

#line default
#line hidden
            );
            EndContext();
            BeginContext(735, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 786, "\"", 848, 1);
            WriteAttributeValue("", 793, 
#line 38 "C:\Users\Admin\Documents\Downloads\test\Tuan 1\Lab1_2_Tuan4\B1_I_3\Views\Nhasanxuat\Index.cshtml"
                              Url.Action("sua","Nhasanxuat",new { id = item.Mansx })

#line default
#line hidden
            , 793, 55, false);
            EndWriteAttribute();
            BeginContext(849, 34, true);
            WriteLiteral(">Sửa</a> |\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 883, "\"", 945, 1);
            WriteAttributeValue("", 890, 
#line 39 "C:\Users\Admin\Documents\Downloads\test\Tuan 1\Lab1_2_Tuan4\B1_I_3\Views\Nhasanxuat\Index.cshtml"
                              Url.Action("xoa","Nhasanxuat",new { id = item.Mansx })

#line default
#line hidden
            , 890, 55, false);
            EndWriteAttribute();
            BeginContext(946, 52, true);
            WriteLiteral(">Xóa</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 42 "C:\Users\Admin\Documents\Downloads\test\Tuan 1\Lab1_2_Tuan4\B1_I_3\Views\Nhasanxuat\Index.cshtml"
        }               
    

#line default
#line hidden

            BeginContext(1031, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591