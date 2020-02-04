﻿using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace GoogleMapsComponents.Maps.Places
{
    public class AutocompleteService : IDisposable
    {
        private readonly JsObjectRef _jsObjectRef;

        public async static Task<AutocompleteService> CreateAsync(IJSRuntime jsRuntime, MarkerOptions opts = null)
        {
            var jsObjectRef = await JsObjectRef.CreateAsync(jsRuntime, "google.maps.places.AutocompleteService", opts);
            var obj = new AutocompleteService(jsObjectRef);

            return obj;
        }

        private AutocompleteService(JsObjectRef jsObjectRef)
        {
            _jsObjectRef = jsObjectRef;
        }

        public void Dispose()
        {
            _jsObjectRef.Dispose();
        }
    }
}
