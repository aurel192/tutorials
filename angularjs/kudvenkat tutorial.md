## [Kudvenkat's Angular tutorials](https://www.youtube.com/playlist?list=PL6n9fhu94yhWKHkcL7RJmmXyxkuFB3KSl)
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

### 05 TwoWay Binding
```html
<!DOCTYPE html>
<html ng-app="myModule">
  <head>   
  <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.3/angular.min.js"></script>
  </head>
  <body>
    <div ng-controller="myController">
        <div>            
            <input type="text" ng-model="message" />                        
            {{message}}            
            <br/><br/>
            <input type="text" ng-model="greeting" />            
            {{greeting}}
        </div>    
        <table>        
            <tr>
                <td>First Name</td>
                <td>
                    <input type="text" ng-model="employee.firstName"/>
                </td>
             </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <input type="text" ng-model="employee.lastName"/>
                </td>
             </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <input type="text" ng-model="employee.gender"/>
                </td>
             </tr>             
        </table>         
        <br/>       
        <table>        
            <tr>
                <td>First Name</td>
                <td>
                    {{employee.firstName}}
                </td>
             </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    {{employee.lastName}}
                </td>
             </tr>
            <tr>
                <td>Gender</td>
                <td>
                    {{employee.gender}}
                </td>
             </tr>             
        </table>         
    </div>            
  </body>
</html>
```
```javascript
var myApp = angular
    .module("myModule", [])
    .controller("myController", function ($scope) {
        $scope.message = "Hello Angular!";
        var employee = {
            firstName:"Ben",
            lastName: "Hastings",
            gender: "Male"
        };
        $scope.employee = employee;
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
