"use strict";
var CoreFile;
(function (CoreFile) {
    CoreFile.GetStringAsync = function (URL) {
        return new Promise(function (Resolve, reject) {
            try {
                var res = new XMLHttpRequest();
                res.open("GET", URL, true);
                res.setRequestHeader("Content-Type", "text/plain;charset=UTF-8");
                res.setRequestHeader("Cache-Control", "no-cache,no-store");
                res.onload = function () {
                    if (res.status == 200) {
                        Resolve({ data: res.responseText });
                    }
                    else {
                        reject({
                            statusText: res.statusText,
                            RequestResponse: res.responseText
                        });
                    }
                };
                res.send();
            }
            catch (e) {
                reject({
                    statusText: e,
                    RequestResponse: null
                });
            }
        });
    };
    CoreFile.GetString = function (URL) {
        try {
            var res = new XMLHttpRequest();
            res.open("GET", URL, false);
            res.setRequestHeader("Content-Type", "text/plain;charset=UTF-8");
            res.setRequestHeader("Cache-Control", "no-cache,no-store");
            res.send();
            if (res.status == 200) {
                return { data: res.responseText, status: 0, statusText: "", RequestResponse: "" };
            }
            else {
                return {
                    data: null,
                    status: res.status,
                    statusText: res.statusText,
                    RequestResponse: res.responseText
                };
            }
        }
        catch (e) {
            return {
                data: null,
                status: -99,
                statusText: e,
                RequestResponse: null
            };
        }
    };
    var SetFormatParametersUrl = function (URL) {
        if (URL.indexOf("?") == -1) {
            return URL + "?Token=" + Math.random();
        }
        else {
            return URL + "&Token=" + Math.random();
        }
    };
})(CoreFile || (CoreFile = {}));
//# sourceMappingURL=CoreFile.js.map