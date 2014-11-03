/// <reference path="../angular.min.js" />
/// <reference path="Modules.js" />
/// <reference path="Services.js" />

app.controller("RESTClientController", function ($scope, RESTClientService) {
    // debugger;
    var promiseGet = RESTClientService.get();

    promiseGet.then(function (pl) {
        $scope.Employees = pl.data
    },
              function (errorPl) {
                  $log.error('failure loading Employee', errorPl);
              });
});

 