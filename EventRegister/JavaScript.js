var eventRegister = angular.module('EventRegister', ['ui.bootstrap']);

eventRegister.controller("EventRegisterController", function ($scope) {
    $scope.persons = [
        { 'FirstName': 'Kolpan', 'LastName': 'Lopertket', 'MiddleInitial' : 'B', 'PhoneNumber':'458-698-756', 'AgeGroup': '2' },
        { 'FirstName': 'Polod', 'LastName': 'Moerlokuse', 'MiddleInitial': 'F', 'PhoneNumber': '254-657-458', 'AgeGroup': '2' }
    ];
});
