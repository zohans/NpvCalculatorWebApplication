// Defining angularjs module
var app = angular.module('npvCalculatorModule', []);

// Defining angularjs Controller and injection NpvCalculatorService
app.controller('npvCalculatorCtrl', function ($scope, $http) {
    $scope.npvCashFlowData = null;

    $scope.NpvInput = {
        Cash: '',
        CashSeries: '',
        LowerBound: '',
        UpperBound: '',
        DiscountRate: ''
    };

    // Reset NpvInput details
    $scope.clear = function () {
        $scope.NpvInput.Cash = '';
        $scope.NpvInput.CashSeries = '';
        $scope.NpvInput.LowerBound = '';
    }

    //Add New Item
    $scope.calculate = function () {
        if ($scope.NpvInput.Cash != "" &&
            $scope.NpvInput.CashSeries != "" &&
            $scope.NpvInput.LowerBound != "") {

            // call Http request using $http                            
            $http({
                method: 'POST',
                url: 'api/NpvCalculator/CalculateCashFlows',
                data: $scope.NpvInput
            }).then(function successCallback (response) {
                // this callback will be called asynchronously
                // when the response is available
                $scope.npvCashFlowData = response.data;
                $scope.clear();
                alert("NpvInput added successfully!!!");
                }, function errorCallback(response) {
                    // called asynchronously if an error occurs
                    // or server returns response with an error status.
                    alert("Error : " + response.data.ExceptionMessage);
                });
        }
        else {
            alert('Please Enter all the values!!');
        }
    }

   // Cancel NpvInput details
    $scope.cancel = function () {
        $scope.clear();
    }
   
});