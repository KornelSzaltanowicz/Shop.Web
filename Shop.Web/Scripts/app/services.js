var shopApp = angular.module('shopAppServices', [])

shopApp.factory('bookService', ['$http', function ($http) {
    var _getAllBooks = function (callback) {

        callback = callback || function () { };

        $http.get('/Data/GetAllBooks')
        .success(function (data) {
            callback(data);
        });
    };

    var _getNewestBooks = function (callback) {

        callback = callback || function () { };

        $http.get('/Data/GetNewestBooks')
        .success(function (data) {
            callback(data);
        });
    };

    var _getPreviewsBooks = function (callback) {

        callback = callback || function () { };

        $http.get('/Data/GetPreviewsBooks')
        .success(function (data) {
            callback(data);
        });
    };

    var _getOpportunitiesBooks = function (callback) {

        callback = callback || function () { };

        $http.get('/Data/GetOpportunityBooks')
        .success(function (data) {
            callback(data);
        });
    };

    var _getBookByType = function (bookType, success, error) {

        success = success || function () { };
        error = error || function () { };

        $http.get('/Data/GetBookByType/' + bookType)
            .success(function (data) {
                success(data);
            })
            .error(error);
    };

    return {
        getAllBooks: _getAllBooks,
        getNewestBooks: _getNewestBooks,
        getPreviewsBooks: _getPreviewsBooks,
        getOpportunitiesBooks: _getOpportunitiesBooks,
        getBookByType: _getBookByType

    }
}]);

