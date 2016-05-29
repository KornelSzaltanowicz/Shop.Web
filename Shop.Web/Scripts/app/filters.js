var shopApp = angular.module('shopAppFilters', []);

shopApp.filter('titleAuthorFilter', function () {

    return function (books, searchQuery) {
        var filteredBooks = [];
        console.log(searchQuery);
        if (!searchQuery) {
            return books;
        }

        for (i = 0; i < books.length; i++) {
            if (books[i].Title.toLowerCase().indexOf(searchQuery.toLowerCase()) > -1 || books[i].Author.FirstName.toLowerCase().indexOf(searchQuery.toLowerCase()) > -1 || books[i].Author.LastName.toLowerCase().indexOf(searchQuery.toLowerCase()) > -1) {
                filteredBooks.push(books[i]);
            };
        }
        if (filteredBooks.length > 0) {
            return filteredBooks;
        }
        else {
            alert('W bazie danych nie odnaleziono produktów spełniających podane kryteria szukania');
        }
    };

});

shopApp.filter("jsDate", function () {
    return function (x) {
        return new Date(parseInt(x.substr(6)));
    };
});