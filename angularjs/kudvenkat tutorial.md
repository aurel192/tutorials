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

### 06 ng-repeat, nesting ng-repeat
```html
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.3/angular.min.js"></script>
</head>
<body ng-app="myModule">
    <div ng-controller="myController">
        <table>
            <thead>
                <tr>
                    <th>Firstname</th>
                    <th>Lastname</th>
                    <th>Gender</th>
                    <th>Salary</th>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="employee in employees">
                    <td> {{ employee.firstName }} </td>
                    <td> {{ employee.lastName }} </td>
                    <td> {{ employee.gender }} </td>
                    <td> {{ employee.salary }} </td>
                </tr>
            </tbody>
        </table>
        <ul>
            <li ng-repeat="country in countries" ng-init="parentIndex=$index">
                {{country.name}} Index={{$index}}
                <ul>
                    <li ng-repeat="city in country.cities">
                        {{city.name}} Parent Index={{parentIndex}} Index={{$index}}
                        <!-- {{city.name}} Parent Index={{$parent.$index}} Index={{$index}} -->
                    </li>
                </ul>            
            </li>
        </ul>
    </div>
</body>
</html>
```
```javascript
var myApp = angular
    .module("myModule", [])
    .controller("myController", function ($scope) {
        var employees = [
            { firstName: "Ben", lastName: "Hastings", gender: "Male", salary: 55000 },
            { firstName: "Sara", lastName: "Paul", gender: "Female", salary: 68000 },
            { firstName: "Mark", lastName: "Holland", gender: "Male", salary: 57000 },
            { firstName: "Pam", lastName: "Macintosh", gender: "Female", salary: 53000 },
            { firstName: "Todd", lastName: "Barber", gender: "Male", salary: 60000 }
        ];
        var countries = [
            {
                name: "UK",
                cities: [
                    { name: "London" },
                    { name: "Birmingham" },
                    { name: "Manchester" }
                ]
            },
            {
                name: "USA",
                cities: [
                    { name: "Los Angeles" },
                    { name: "Chicago" },
                    { name: "Houston" }
                ]
            },
            {
                name: "India",
                cities: [
                    { name: "Hyderabad" },
                    { name: "Chennai" },
                    { name: "Mumbai" }
                ]
            }
        ];
        $scope.employees = employees;        
        $scope.countries = countries;        
    });    
```

### title
```html
```
```javascript
```
