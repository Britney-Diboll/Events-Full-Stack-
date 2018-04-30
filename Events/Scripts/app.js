console.log("its alive");

const app = angular.module("main", ["ngRoute"]);

app.config(function ($routeProvider) {

    $routeProvider.when("/events", {
        templateUrl: "/Scripts/app/views/allevents.html",
        controller: "allEventsController"
    })

    $routeProvider.when("/events/:eventID", {
        templateUrl: "/Scripts/app/views/oneEvent.html",
        controller: "oneEventController"
    })

    $routeProvider.otherwise({ redirectTo: "/events" })
})

app.controller("oneEventController", ["$scope", "$routeParams", "$http", function ($scope, $routeParams, $http) {
    console.log($routeParams);
    $http({
        method: "GET",
        url: "/api/events/" + $routeParams.eventID
    }).then(result => {
        $scope.event = result.data;
    })
}])

app.controller("allEventsController", ["$scope", "$http", function ($scope, $http) {
    $http({
        method: "GET",
        url: "/api/event"
    }).then(result => {
        $scope.events = result.data;
    })

}])
