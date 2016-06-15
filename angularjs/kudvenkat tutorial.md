### 01 Hello Angular!
```html
<!DOCTYPE html>
<html ng-app="myModule">
  <head>
    <link rel="stylesheet" type="text/css" href="bootstrap.min.css" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.3/angular.min.js"></script>
    <!-- <script type="text/javascript" src="01_helloworld.js"></script> -->
  </head>
  <body>
    <div>
        40+50 = {{40+50}}
    </div>    
    <div ng-controller="myController">
        {{message}}
    </div>    
  </body>
</html>
```

```javascript
var myApp = angular.module("myModule", []);

var myController = function ($scope) {
  $scope.message = "AngularJS Tutorial";  
};
myApp.controller("myController" , myController);
// OR
myApp.controller("myController" , function ($scope) {
  $scope.message = "AngularJS Tutorial";  
});
```

### 02 Modules and Controllers
```html
<!DOCTYPE html>
<html ng-app="myModule">
  <head>
    <link rel="stylesheet" type="text/css" href="bootstrap.min.css" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.3/angular.min.js"></script>
  </head>
  <body>
    <div>
        40+50 = {{40+50}}
    </div>    
    <div ng-controller="myController">
        {{message}}
    </div>    
  </body>
</html>
```
```javascript
var myApp = angular.module("myModule", []);

var myController2 = function ($scope) {
    $scope.message2 = "AngularJS Tutorial";  
};
myApp.controller("myController2" , myController2);

myApp.controller("myController" , function ($scope) {
    $scope.message = "AngularJS Tutorial";  
});
```

### 03 Controllers
```html
<!DOCTYPE html>
<html ng-app="myModule">
  <head>
    <link rel="stylesheet" type="text/css" href="bootstrap.min.css" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.3/angular.min.js"></script>
  </head>
  <body>
    <div>
        40+50 = {{40+50}}
    </div>    
    <div ng-controller="myController">
        {{message}}
        <p>
        FN: {{employee.firstName}}
    </div>    
  </body>
</html>
```
```javascript
var myApp = angular
                .module("myModule", [])
                .controller("myController", function ($scope) {
                    var employee = {
                    firstName: 'David',
                    lastName: 'Hastings',
                    gender: 'Male'
                };
                $scope.employee = employee;
                $scope.message = "AngularJS Tutorial";  
                });
```

### 04 ng-src
```html
<!DOCTYPE html>
<html ng-app="myModule">
  <head>   
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.3/angular.min.js"></script>
  </head>
  <body>
    <div ng-controller="myController">
        <div>
            Name : {{country.name}}      
        </div>   
        <div>
            Capital : {{country.capital}}      
        </div>           
        <div>
            <img ng-src="{{ country.flag }}" alt="{{ country.name +' Flag'}}" style="height:108px; width:192px" />
        </div>           
    </div>            
  </body>
</html>
```
```javascript
var myApp = angular
                .module("myModule", [])
                .controller("myController", function ($scope) {
                    var country = {
                    name: "USA",
                    capital: "Washington, D.C.",
                    flag: 'Images/usa-flag.jpg'
                };
                $scope.country = country;                
            });
```

### title
```html
```
```javascript
```

### title
```html
```
```javascript
```

### title
```html
```
```javascript
```
