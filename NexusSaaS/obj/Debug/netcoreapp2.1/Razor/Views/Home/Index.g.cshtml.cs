#pragma checksum "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d8c6c3bec8752abe2548f48aa691caa69dcb82a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\_ViewImports.cshtml"
using NexusSaaS;

#line default
#line hidden
#line 2 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\_ViewImports.cshtml"
using NexusSaaS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d8c6c3bec8752abe2548f48aa691caa69dcb82a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"781d58719822ae4423193b9976002c05722650a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NexusSaaS.Models.FeatureModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_NexusLayout";

#line default
#line hidden
            BeginContext(121, 2864, true);
            WriteLiteral(@"
<section class=""home_banner_area"">
    <div class=""banner_inner"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-5"">
                    <div class=""banner_content"">
                        <h2>Mass People <br />Oriented Software</h2>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim. sed do eiusmod tempor incididunt.</p>
                        <a class=""banner_btn"" href=""#"">Get Started</a>
                        <a class=""banner_btn2"" href=""#"">Download</a>
                    </div>
                </div>
                <div class=""col-lg-7"">
                    <div class=""home_left_img"">
                        <img class=""img-fluid"" src=""img/banner/home-left-1.png"" alt="""">
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""work_area p_120"">
");
            WriteLiteral(@"    <div class=""container"">
        <div class=""main_title"">
            <h2>How It work for you</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.</p>
        </div>
        <div class=""work_inner row"">
            <div class=""col-lg-4"">
                <div class=""work_item"">
                    <i class=""lnr lnr-screen""></i>
                    <a href=""#""><h4>Stunning Visuals</h4></a>
                    <p>Here, I focus on a range of items and features that we use in life without giving them a second thought such as Coca Cola.</p>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""work_item"">
                    <i class=""lnr lnr-code""></i>
                    <a href=""#""><h4>Stunning Visuals</h4></a>
                    <p>Here, I focus on a range of items and features that we use in life w");
            WriteLiteral(@"ithout giving them a second thought such as Coca Cola.</p>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""work_item"">
                    <i class=""lnr lnr-clock""></i>
                    <a href=""#""><h4>Stunning Visuals</h4></a>
                    <p>Here, I focus on a range of items and features that we use in life without giving them a second thought such as Coca Cola.</p>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================End Work Area =================-->
<!--================Made Life Area =================-->
<section class=""made_life_area p_120"">
    <div class=""container"">
        <div class=""made_life_inner"">
            <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
");
            EndContext();
#line 79 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                 for (var i = 0; i < Model.Count(); i++)
                {
                    if (i == 0)
                    {

#line default
#line hidden
            BeginContext(3922, 124, true);
            WriteLiteral("                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link active show\" data-toggle=\"tab\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4046, "\"", 4070, 3);
            WriteAttributeValue("", 4053, "#", 4053, 1, true);
#line 84 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
WriteAttributeValue("", 4054, Model[0].Id, 4054, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 4066, "-tab", 4066, 4, true);
            EndWriteAttribute();
            BeginContext(4071, 33, true);
            WriteLiteral(" role=\"tab\" aria-selected=\"true\">");
            EndContext();
            BeginContext(4105, 13, false);
#line 84 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                                                                                                                                  Write(Model[0].Name);

#line default
#line hidden
            EndContext();
            BeginContext(4118, 37, true);
            WriteLiteral("</a>\r\n                        </li>\r\n");
            EndContext();
#line 86 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(4227, 112, true);
            WriteLiteral("                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link\" data-toggle=\"tab\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4339, "\"", 4363, 3);
            WriteAttributeValue("", 4346, "#", 4346, 1, true);
#line 90 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
WriteAttributeValue("", 4347, Model[i].Id, 4347, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 4359, "-tab", 4359, 4, true);
            EndWriteAttribute();
            BeginContext(4364, 33, true);
            WriteLiteral(" role=\"tab\" aria-selected=\"true\">");
            EndContext();
            BeginContext(4398, 13, false);
#line 90 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                                                                                                                      Write(Model[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(4411, 37, true);
            WriteLiteral("</a>\r\n                        </li>\r\n");
            EndContext();
#line 92 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                    }

                }

#line default
#line hidden
            BeginContext(4492, 76, true);
            WriteLiteral("            </ul>\r\n            <div class=\"tab-content\" id=\"myTabContent\">\r\n");
            EndContext();
#line 165 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                 for (var i = 0; i < Model.Count(); i++)
                {
                    if (i == 0)
                    {

#line default
#line hidden
            BeginContext(9183, 62, true);
            WriteLiteral("                        <div class=\"tab-pane fade show active\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 9245, "\"", 9266, 2);
#line 169 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
WriteAttributeValue("", 9250, Model[0].Id, 9250, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 9262, "-tab", 9262, 4, true);
            EndWriteAttribute();
            BeginContext(9267, 247, true);
            WriteLiteral(" role=\"tabpanel\">\r\n                            <div class=\"row made_life_text\">\r\n                                <div class=\"col-lg-6\">\r\n                                    <div class=\"left_side_text\">\r\n                                        <h3>");
            EndContext();
            BeginContext(9515, 14, false);
#line 173 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                                       Write(Model[0].Title);

#line default
#line hidden
            EndContext();
            BeginContext(9529, 51, true);
            WriteLiteral("</h3>\r\n                                        <h6>");
            EndContext();
            BeginContext(9581, 20, false);
#line 174 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                                       Write(Model[0].Description);

#line default
#line hidden
            EndContext();
            BeginContext(9601, 50, true);
            WriteLiteral("</h6>\r\n                                        <p>");
            EndContext();
            BeginContext(9652, 16, false);
#line 175 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                                      Write(Model[0].Content);

#line default
#line hidden
            EndContext();
            BeginContext(9668, 541, true);
            WriteLiteral(@"</p>
                                        <a class=""main_btn"" href=""#"">Get Started Now</a>
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""chart_img"">
                                        <img class=""img-fluid"" src=""img/chart.jpg"" alt="""">
                                    </div>
                                </div>
                            </div>
                        </div>
");
            EndContext();
#line 186 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(10281, 55, true);
            WriteLiteral("                        <div class=\"tab-pane fade show\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 10336, "\"", 10357, 2);
#line 189 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
WriteAttributeValue("", 10341, Model[i].Id, 10341, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 10353, "-tab", 10353, 4, true);
            EndWriteAttribute();
            BeginContext(10358, 247, true);
            WriteLiteral(" role=\"tabpanel\">\r\n                            <div class=\"row made_life_text\">\r\n                                <div class=\"col-lg-6\">\r\n                                    <div class=\"left_side_text\">\r\n                                        <h3>");
            EndContext();
            BeginContext(10606, 14, false);
#line 193 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                                       Write(Model[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(10620, 51, true);
            WriteLiteral("</h3>\r\n                                        <h6>");
            EndContext();
            BeginContext(10672, 20, false);
#line 194 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                                       Write(Model[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(10692, 50, true);
            WriteLiteral("</h6>\r\n                                        <p>");
            EndContext();
            BeginContext(10743, 16, false);
#line 195 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                                      Write(Model[i].Content);

#line default
#line hidden
            EndContext();
            BeginContext(10759, 359, true);
            WriteLiteral(@"</p>
                                        <a class=""main_btn"" href=""#"">Get Started Now</a>
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""chart_img"">
                                        <img class=""img-fluid""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 11118, "\"", 11140, 1);
#line 201 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
WriteAttributeValue("", 11124, Model[i].ImgUrl, 11124, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(11141, 162, true);
            WriteLiteral(" alt=\"\">\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 206 "C:\Users\VuPhuc\source\repos\NexusSaaS\NexusSaaS\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(11345, 13603, true);
            WriteLiteral(@"            </div>
        </div>
</section>
<!--================End Made Life Area =================-->
<!--================Screen Area =================-->
<section class=""screen_area text-center p_120"">
    <div class=""container"">
        <div class=""main_title"">
            <h2>Unique Screens that work perfectly</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.</p>
        </div>
        <img class=""img-fluid"" src=""img/banner/home-left-1.png"" alt="""">
    </div>
</section>
<!--================End Screen Area =================-->
<!--================Made Life Area =================-->
<section class=""made_life_area p_120"">
    <div class=""container"">
        <div class=""made_life_inner"">
            <div class=""row made_life_text"">
                <div class=""col-lg-6"">
                    <div class=""left_side_text"">
                       ");
            WriteLiteral(@" <h3>We’ve made a life <br />that will change you</h3>
                        <h6>We are here to listen from you deliver exellence</h6>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp or incididunt ut labore et dolore magna aliqua. Ut enim ad minim.</p>
                        <a class=""main_btn"" href=""#"">Get Started Now</a>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""chart_img"">
                        <img class=""img-fluid"" src=""img/browser.png"" alt="""">
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================End Made Life Area =================-->
<!--================Price Area =================-->
<section class=""price_area p_120"">
    <div class=""container"">
        <div class=""main_title"">
            <h2>Choose Your Price Plan</h2>
            <p>Lorem ipsum dolor sit amet, consect");
            WriteLiteral(@"etur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.</p>
        </div>
        <div class=""price_inner row"">
            <div class=""col-lg-4"">
                <div class=""price_item"">
                    <div class=""price_head"">
                        <h4>Real Basic</h4>
                    </div>
                    <div class=""price_body"">
                        <ul class=""list"">
                            <li><a href=""#"">2.5 GB Space</a></li>
                            <li><a href=""#"">Secure Online Transfer</a></li>
                            <li><a href=""#"">Unlimited Styles</a></li>
                            <li><a href=""#"">Customer Service</a></li>
                        </ul>
                    </div>
                    <div class=""price_footer"">
                        <h3><span class=""dlr"">$</span> 39 <span class=""month"">Per <br />Month</span></h3>
                        <a class=""ma");
            WriteLiteral(@"in_btn"" href=""#"">Get Started</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""price_item"">
                    <div class=""price_head"">
                        <h4>Real Standard</h4>
                    </div>
                    <div class=""price_body"">
                        <ul class=""list"">
                            <li><a href=""#"">10 GB Space</a></li>
                            <li><a href=""#"">Secure Online Transfer</a></li>
                            <li><a href=""#"">Unlimited Styles</a></li>
                            <li><a href=""#"">Customer Service</a></li>
                        </ul>
                    </div>
                    <div class=""price_footer"">
                        <h3><span class=""dlr"">$</span> 69 <span class=""month"">Per <br />Month</span></h3>
                        <a class=""main_btn"" href=""#"">Get Started</a>
                    </div>
                </div>
        ");
            WriteLiteral(@"    </div>
            <div class=""col-lg-4"">
                <div class=""price_item"">
                    <div class=""price_head"">
                        <h4>Real Ultimate</h4>
                    </div>
                    <div class=""price_body"">
                        <ul class=""list"">
                            <li><a href=""#"">Unlimited Space</a></li>
                            <li><a href=""#"">Secure Online Transfer</a></li>
                            <li><a href=""#"">Unlimited Styles</a></li>
                            <li><a href=""#"">Customer Service</a></li>
                        </ul>
                    </div>
                    <div class=""price_footer"">
                        <h3><span class=""dlr"">$</span> 99 <span class=""month"">Per <br />Month</span></h3>
                        <a class=""main_btn"" href=""#"">Get Started</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================End Price Area ===");
            WriteLiteral(@"==============-->
<!--================Testimonials Area =================-->
<section class=""testimonials_area p_120"">
    <div class=""container"">
        <div class=""main_title"">
            <h2>Feedback from Customers</h2>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.</p>
        </div>
        <div class=""testi_slider owl-carousel"">
            <div class=""item"">
                <div class=""testi_item"">
                    <div class=""media"">
                        <div class=""d-flex"">
                            <img src=""img/testimonials/testi-1.png"" alt="""">
                        </div>
                        <div class=""media-body"">
                            <p>Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker, projector, hardware.</p>
                            <h4>Mark Alviro");
            WriteLiteral(@" Wiens</h4>
                            <div class=""rating"">
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star-half-o""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""testi_item"">
                    <div class=""media"">
                        <div class=""d-flex"">
                            <img src=""img/testimonials/testi-2.png"" alt="""">
                        </div>
                        <div class=""media-body"">
                            <p>Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker, projector, hardware.</p>
                          ");
            WriteLiteral(@"  <h4>Mark Alviro Wiens</h4>
                            <div class=""rating"">
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star-half-o""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""testi_item"">
                    <div class=""media"">
                        <div class=""d-flex"">
                            <img src=""img/testimonials/testi-1.png"" alt="""">
                        </div>
                        <div class=""media-body"">
                            <p>Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker, projector, hardware.</p>
         ");
            WriteLiteral(@"                   <h4>Mark Alviro Wiens</h4>
                            <div class=""rating"">
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star-half-o""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""testi_item"">
                    <div class=""media"">
                        <div class=""d-flex"">
                            <img src=""img/testimonials/testi-2.png"" alt="""">
                        </div>
                        <div class=""media-body"">
                            <p>Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker, projector, hardwar");
            WriteLiteral(@"e.</p>
                            <h4>Mark Alviro Wiens</h4>
                            <div class=""rating"">
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star-half-o""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""testi_item"">
                    <div class=""media"">
                        <div class=""d-flex"">
                            <img src=""img/testimonials/testi-1.png"" alt="""">
                        </div>
                        <div class=""media-body"">
                            <p>Accessories Here you can find the best computer accessory for your laptop, monitor, printer, scanner, speaker, p");
            WriteLiteral(@"rojector, hardware.</p>
                            <h4>Mark Alviro Wiens</h4>
                            <div class=""rating"">
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star-half-o""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""testi_item"">
                    <div class=""media"">
                        <div class=""d-flex"">
                            <img src=""img/testimonials/testi-2.png"" alt="""">
                        </div>
                        <div class=""media-body"">
                            <p>Accessories Here you can find the best computer accessory for your laptop, monitor, printer, sc");
            WriteLiteral(@"anner, speaker, projector, hardware.</p>
                            <h4>Mark Alviro Wiens</h4>
                            <div class=""rating"">
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star-half-o""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================End Testimonials Area =================-->
<!--================Made Life Area =================-->
<section class=""made_life_area made_white p_120"">
    <div class=""container"">
        <div class=""made_life_inner"">
            <div class=""row made_life_text"">
                <div class=""col-lg-6"">
                    <div class=""chart_img"">
                  ");
            WriteLiteral(@"      <img class=""img-fluid"" src=""img/banner/home-left-1.png"" alt="""">
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""left_side_text"">
                        <h3>We’ve made a life <br />that will change you</h3>
                        <h6>We are here to listen from you deliver exellence</h6>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp or incididunt ut labore et dolore magna aliqua. Ut enim ad minim.</p>
                        <a class=""main_btn"" href=""#"">Get Started Now</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================End Made Life Area =================-->
<!--================Impress Area =================-->
<section class=""impress_area p_120"">
    <div class=""container"">
        <div class=""impress_inner"">
            <h2>Got Impressed to our features?</h2>
            <p");
            WriteLiteral(@">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore  et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.</p>
            <a class=""banner_btn2"" href=""#"">Request Free Demo</a>
        </div>
    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NexusSaaS.Models.FeatureModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
