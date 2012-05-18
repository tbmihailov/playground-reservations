﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlaygroundReservations.Helpers
{
    public static class UrlHelperExtensions
    {
        public static string GetImageUrl(this UrlHelper urlHelper, string imageName)
        {
            string imageUrl = urlHelper.Action("GetImage", "Image", new { @imageName = imageName });
            return urlHelper.Content(imageUrl);
        }
    }
}