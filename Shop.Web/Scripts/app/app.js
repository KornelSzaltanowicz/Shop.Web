(function () {
    'use strict';
    var shopApp = angular.module('shopApp', ['ngRoute']);

    var selectedBooks = {};

    shopApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $routeProvider
            .when('/', {
                templateUrl: '../Scripts/app/templates/newest.html',
                controller: 'NewestController'
            })
            .when('/book/newest', {
                templateUrl: '../Scripts/app/templates/newest.html',
                controller: 'NewestController'
            })
            .when('/book/previews', {
                templateUrl: '../Scripts/app/templates/newest.html',
                controller: 'NewestController'
            })
             .when('/book/opportunity', {
                 templateUrl: '../Scripts/app/templates/newest.html',
                 controller: 'NewestController'
             })
            .otherwise({
                redirectTo: '/'
            });

        $locationProvider.html5Mode({ enabled: true, requireBase: false });

    }]);


    shopApp.controller('NewestController', ['$scope', 'newestService', function ($scope, newestService) {

        $scope.Books = null;
        newestService.GetBooks().then(function (d) {
            $scope.Books = d.data; //success
            selectedBooks = d.data;
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



    shopApp.filter("jsDate", function () {
        return function (x) {
            return new Date(parseInt(x.substr(6)));
        };
    });

    shopApp.controller('SearchController', ['$scope', '$log', function ($scope, $log) {

        var searchResult = [];
        $scope.searchQuery = '';
        $scope.searchBtnClick = false;

        $scope.GoSearch = function (data) {
            $scope.searchQuery = data;
        };


        $scope.search = function () {
            if (selectedBooks != null) {
                makeResultArray($scope.searchTxt);
                if (searchResult.length < 1) {
                    alert('W bazie danych nie odnaleziono produktów spełniających podane kryteria szukania');
                }
                else {
                    $log.info(searchResult);
                };
            };
        };

        var makeResultArray = function (searchTxt) {
            angular.forEach(selectedBooks, function (value, key) {
                if (value.Title.toLowerCase().indexOf(searchTxt.toLowerCase()) > -1 || value.Author.FirstName.toLowerCase().indexOf(searchTxt.toLowerCase()) > -1 || value.Author.LastName.toLowerCase().indexOf(searchTxt.toLowerCase()) > -1) {
                    searchResult.push(value);
                }
            });
        }

    }]);

    shopApp.filter('titleAuthorFilter', function () {
        
        return function (books, searchQuery) {
            console.log(searchQuery);
            if (!searchQuery) {
                return books;
            }

            return books.filter(function (element) {
                
                return (element.Title.toLowerCase().indexOf(searchQuery.toLowerCase()) > -1);
                
                
                //if (book.Title.toLowerCase().indexOf(searchQuery.toLowerCase()) > -1 || book.Author.FirstName.toLowerCase().indexOf(searchQuery.toLowerCase()) > -1 || book.Author.LastName.toLowerCase().indexOf(searchQuery.toLowerCase()) > -1) {
                //    console.log("cokolwiek");
                //    return book;
                //} else {
                //    alert('W bazie danych nie odnaleziono produktów spełniających podane kryteria szukania');
                //}
            });
        };

    });

})();