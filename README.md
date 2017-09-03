# [Eml.HtmlHelpers](https://preview.nuget.org/packages/Eml.HtmlHelpers/)
Contains CheckBoxFor(an alternative for RememberMe checkbox in MVC scaffolding) and IsActive(for keeping the active controller in-sync with the header menu).

## A. Usage - ***CheckBoxFor***    
```xml
    @using Eml.HtmlHelpers.Checkbox

    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            @Html.Bootstrap().CheckBoxFor(m => m.RememberMe)
        </div>
    </div>
 ```

### Add ***eml-checkbox.css*** into your BundleConfig.cs
```javascript
    bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/eml-checkbox.css"
                ));
 ```

## B. Usage - ***IsActive***    
```xml
    @using Eml.HtmlHelpers.IsActive

    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Application name", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" })
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li class="@Html.IsActiveAction("Index")">@Html.ActionLink("Home", "Index", "Home")</li>
                    <li class="@Html.IsActiveAction("About")">@Html.ActionLink("About", "About", "Home")</li>
                    <li class="@Html.IsActiveAction("Contact")">@Html.ActionLink("Contact", "Contact", "Home")</li>
                </ul>
                @Html.Partial("_LoginPartial")
            </div>
        </div>
    </div>
 ```


## Enjoy!
