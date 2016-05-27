(function () {
    'use strict';
    var shopApp = angular.module('shopApp', ['ngRoute']);

    shopApp.config(['$routeProvider', function ($routeProvider) {

        $routeProvider
        .when('/book/newest', {
            templateUrl: '/Scripts/app/templates/previews.html',
            controller: 'NewestController'
        }).
        otherwise({
            redirectTo: '/'
        });

    }]);


    shopApp.controller('NewestController', ['$scope', 'newestService', function ($scope, newestService) {

        $scope.Books = null;
        newestService.GetBooks().then(function (d) {
            $scope.Books = d.data; //success
            console.log($scope.Books);
        }, function () {
            alert('Failed!');
        });
    }]);


    shopApp.factory('newestService', ['$http', function ($http) {
        var op = {};
        op.GetBooks = function () {
            return $http.get('/Data/GetNewestBooks');
        }
        return op;
    }]);

})();