(function () {
    'use strict';
    var shopApp = angular.module('shopApp', ['ngRoute', 'shopAppServices', 'shopAppFilters', 'angular-loading-bar', 'ngAnimate']);

    var selectedBooks = {};

    shopApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $routeProvider
            .when('/', {
                templateUrl: '../Scripts/app/templates/index.html',
                controller: 'AllBooksController'
            })
            .when('/book/newest', {
                templateUrl: '../Scripts/app/templates/newest.html',
                controller: 'NewestBooksController'
            })
            .when('/book/previews', {
                templateUrl: '../Scripts/app/templates/previews.html',
                controller: 'PreviewsBooksController'
            })
             .when('/book/opportunity', {
                 templateUrl: '../Scripts/app/templates/opportunity.html',
                 controller: 'OpportunitiesBooksController'
             })
            .when('/book/type/:bookType', {
                templateUrl: '../Scripts/app/templates/booktype.html',
                controller: 'BookByTypeController'
            })
            .otherwise({
                redirectTo: '/'
            });

        $locationProvider.html5Mode({ enabled: true, requireBase: false });

    }]);

    shopApp.controller('NewestBooksController', ['$scope', 'bookService', function ($scope, bookService) {

        $scope.Books = [];
        bookService.getNewestBooks(function (books) {
            $scope.Books = books;
        });
    }]);

    shopApp.controller('AllBooksController', ['$scope', 'bookService', function ($scope, bookService) {

        $scope.Books = [];
        bookService.getAllBooks(function (books) {
            $scope.Books = books;
        });
    }]);

    shopApp.controller('PreviewsBooksController', ['$scope', 'bookService', function ($scope, bookService) {

        $scope.Books = [];
        bookService.getPreviewsBooks(function (books) {
            $scope.Books = books;
        });
    }]);

    shopApp.controller('OpportunitiesBooksController', ['$scope', 'bookService', function ($scope, bookService) {

        $scope.Books = [];
        bookService.getOpportunitiesBooks(function (books) {
            $scope.Books = books;
        });
    }]);

    shopApp.controller('BookByTypeController', ['$scope', '$routeParams', 'bookService', function ($scope, $routeParams, bookService) {

        $scope.Books = [];
        $scope.booksType = $routeParams.bookType;
        bookService.getBookByType($scope.booksType, function (data) {
            $scope.Books = data;
        });
    }]);

    shopApp.controller('MainController', ['$scope', function ($scope) {

        $scope.searchQuery = '';
        $scope.itemsAmount = 0;

        $scope.setItemsAmount = function (data) {
            $scope.itemsAmount = data;
        };

        $scope.resetItemsAmount = function() {
            $scope.itemsAmount = 0;
        };
    }]);

})();