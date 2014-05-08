var eventRegister = angular.module('EventRegister', ['ui.bootstrap', 'ngResource']);

eventRegister.factory('PersonList', function ($resource) {
    return new $resource('/api/EventRegister');
});

eventRegister.controller("EventRegisterController", function ($scope, PersonList) {
    $scope.persons = PersonList.query();
});
