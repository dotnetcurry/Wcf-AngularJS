/// <reference path="../angular.min.js" />
/// <reference path="../angular-resource.min.js" />
/// <reference path="Modules.js" />

app.service("RESTClientService", function ($http) {
    //debugger;
    this.get = function () {
            return $http.get("http://localhost:8020/WCFApp/Service.svc/Employees");
    };
});