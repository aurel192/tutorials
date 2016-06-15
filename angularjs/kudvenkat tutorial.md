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
<img src="http://3.bp.blogspot.com/-O8t0qot_LTI/VjkfL3fJ_fI/AAAAAAAAf88/faf5rlKViaQ/s1600/Two%2Bway%2Bbinding%2Bexample%2Bwith%2Bcomplext%2Bobject.png" width="200">
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
<img src="http://1.bp.blogspot.com/-swjaMA47DkQ/VjnxBynvrSI/AAAAAAAAf98/WaQqtSEovSI/s1600/AngularJS%2Bng-repeat%2Bdirective.png" width="350">
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

### 07 Handling Events
<img src="http://2.bp.blogspot.com/-RuZnPBf8rdI/VjuuRAihIMI/AAAAAAAAf_Y/sOGHTgdnKWw/s1600/Handling%2Bevents%2Bin%2BAngularJS.png" width="200">
```html
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.3/angular.min.js"></script>
    <link href="Styles.css" rel="stylesheet" />   
    <style>
        table {
            border-collapse: collapse;
            font-family:Arial;
        }

        td {
            border: 1px solid black;
            padding: 5px;
        }

        th {
            border: 1px solid black;
            padding: 5px;
            text-align: left;
        }
    </style>    
</head>
<body ng-app="myModule">
    <div ng-controller="myController">
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Likes</th>
                    <th>Dislikes</th>
                    <th>Like/Dislike</th>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="technology in technologies">
                    <td> {{ technology.name }} </td>
                    <td style="text-align:center"> {{ technology.likes }} </td>
                    <td style="text-align:center"> {{ technology.dislikes }} </td>
                    <td>
                        <input type="button" ng-click="incrementLikes(technology)" value="Like" />
                        <input type="button" ng-click="incrementDislikes(technology)" value="Dislike" />
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</body>
</html>
```
```javascript
var app = angular
    .module("myModule", [])
    .controller("myController", function ($scope) {
        var technologies = [
            { name: "C#", likes: 0, dislikes: 0 },
            { name: "ASP.NET", likes: 0, dislikes: 0 },
            { name: "SQL", likes: 0, dislikes: 0 },
            { name: "AngularJS", likes: 0, dislikes: 0 }
        ];
        $scope.technologies = technologies;

        $scope.incrementLikes = function (technology) {
            technology.likes++;
        };
        $scope.incrementDislikes = function (technology) {
            technology.dislikes++;
        };
    });   
```

### 08 Filters
<img src="http://2.bp.blogspot.com/-Bpww9K7k--o/Vjz_AqeEyII/AAAAAAAAgAo/yk1cTGMx8Js/s1600/angularjs%2Bfilters%2Bexample.png" width="300">
```html
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.3/angular.min.js"></script>
    <style>
        body {
            font-family: Arial;
        }
        table {
            border-collapse: collapse;
        }
        td {
            border: 1px solid black;
            padding: 5px;
        }
        th {
            border: 1px solid black;
            padding: 5px;
            text-align: left;
        }
    </style>    
</head>
<body ng-app="myModule">
    <div ng-controller="myController">
        Rows to display : <input type="number" step="1" ng-model="rowCount" max="5" min="0" />
        <br /><br />
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Date of Birth</th>
                    <th>Gender</th>
                    <th>Salary (number filter)</th>
                    <th>Salary (currency filter)</th>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="employee in employees | limitTo:rowCount">
                    <td> {{ employee.name | uppercase }} </td>
                    <td> {{ employee.dateOfBirth | date:"dd/MM/yyyy" }} </td>
                    <td> {{ employee.gender }} </td>
                    <td> {{ employee.salary | number:2 }} </td>
                    <td> {{ employee.salary | currency : "£" : 1 }} </td>
                </tr>
            </tbody>
        </table>
    </div>
</body>
</html>
```
```javascript
var app = angular
    .module("myModule", [])
    .controller("myController", function ($scope) {
        var employees = [
            {
                name: "Ben", dateOfBirth: new Date("November 23, 1980"),
                gender: "Male", salary: 55000.788
            },
            {
                name: "Sara", dateOfBirth: new Date("May 05, 1970"),
                gender: "Female", salary: 68000
            },
            {
                name: "Mark", dateOfBirth: new Date("August 15, 1974"),
                gender: "Male", salary: 57000
            },
            {
                name: "Pam", dateOfBirth: new Date("October 27, 1979"),
                gender: "Female", salary: 53000
            },
            {
                name: "Todd", dateOfBirth: new Date("December 30, 1983"),
                gender: "Male", salary: 60000
            }
        ];
        $scope.employees = employees;
        $scope.rowCount = 3;
    });  
```

### 09 Sorting Data
<img src="http://4.bp.blogspot.com/-auD4R-xXdcI/Vj471afFpWI/AAAAAAAAgE0/k49haWyNhbs/s1600/sorting%2Bdata%2Bin%2Bangularjs.png" width="150">
```html
<!DOCTYPE html>
<head>
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.3/angular.min.js"></script>
</head>
<body ng-app="myModule">
    <div ng-controller="myController">
        Sort By :
        <select ng-model="sortColumn">
            <option value="name">Name ASC</option>
            <option value="+dateOfBirth">Date of Birth ASC</option>
            <option value="+gender">Gender ASC</option>
            <option value="-salary">Salary DESC</option>
        </select>
        <br /><br />
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Date of Birth</th>
                    <th>Gender</th>
                    <th>Salary</th>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="employee in employees | orderBy:sortColumn">
                    <td>
                        {{ employee.name }}
                    </td>
                    <td>
                        {{ employee.dateOfBirth | date:"dd/MM/yyyy" }}
                    </td>
                    <td>
                        {{ employee.gender }}
                    </td>
                    <td>
                        {{ employee.salary  }}
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</body>
</html>
```
```javascript
var app = angular
    .module("myModule", [])
    .controller("myController", function ($scope) {
        var employees = [
            {
                name: "Ben", dateOfBirth: new Date("November 23, 1980"),
                gender: "Male", salary: 55000
            },
            {
                name: "Sara", dateOfBirth: new Date("May 05, 1970"),
                gender: "Female", salary: 68000
            },
            {
                name: "Mark", dateOfBirth: new Date("August 15, 1974"),
                gender: "Male", salary: 57000
            },
            {
                name: "Pam", dateOfBirth: new Date("October 27, 1979"),
                gender: "Female", salary: 53000
            },
            {
                name: "Todd", dateOfBirth: new Date("December 30, 1983"),
                gender: "Male", salary: 60000
            }
        ];
        $scope.employees = employees;
        $scope.sortColumn = "name";

    });
```

### 10 Sort rows by table header
```html
<!DOCTYPE html>
<head>
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.3/angular.min.js"></script>
        <style>
        body {
            font-family: Arial;
        }

        table {
            border-collapse: collapse;
        }

        td {
            border: 1px solid black;
            padding: 5px;
        }

        th {
            border: 1px solid black;
            padding: 5px;
            text-align: left;
            /*cursor property displays hand symbol
                when hovered over the th element*/
            cursor: pointer;
        }

        /*This class displays the UP arrow*/
        .arrow-up {
             width: 0;
             height: 0;
             border-left: 5px solid transparent;
             border-right: 5px solid transparent;
             border-bottom: 10px solid black;
             display:inline-block;
        }

        /*This class displays the DOWN arrow*/
        .arrow-down {
             width: 0;
             height: 0;
             border-left: 5px solid transparent;
             border-right: 5px solid transparent;
             border-top: 10px solid black;
             display:inline-block;
        }
        </style>    
</head>
<body ng-app="myModule">
    <div ng-controller="myController">
        <table>
            <thead>
                <tr>
                    <th ng-click="sortData('name')">
                        Name <div ng-class="getSortClass('name')"></div>
                    </th>
                    <th ng-click="sortData('dateOfBirth')">
                        Date of Birth <div ng-class="getSortClass('dateOfBirth')"></div>
                    </th>
                    <th ng-click="sortData('gender')">
                        Gender <div ng-class="getSortClass('gender')"></div>
                    </th>
                    <th ng-click="sortData('salary')">
                        Salary <div ng-class="getSortClass('salary')"></div>
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="employee in employees | orderBy:sortColumn:reverseSort">
                    <td> {{ employee.name }} </td>
                    <td> {{ employee.dateOfBirth | date:"dd/MM/yyyy" }} </td>
                    <td> {{ employee.gender }} </td>
                    <td> {{ employee.salary  }} </td>
                </tr>
            </tbody>
        </table>
    </div>
</body>
</html>
```
```javascript
var app = angular
    .module("myModule", [])
    .controller("myController", function ($scope) {
        var employees = [
            {
                name: "Ben", dateOfBirth: new Date("November 23, 1980"),
                gender: "Male", salary: 55000
            },
            {
                name: "Sara", dateOfBirth: new Date("May 05, 1970"),
                gender: "Female", salary: 68000
            },
            {
                name: "Mark", dateOfBirth: new Date("August 15, 1974"),
                gender: "Male", salary: 57000
            },
            {
                name: "Pam", dateOfBirth: new Date("October 27, 1979"),
                gender: "Female", salary: 53000
            },
            {
                name: "Todd", dateOfBirth: new Date("December 30, 1983"),
                gender: "Male", salary: 60000
            }
        ];
        $scope.employees = employees;
        $scope.sortColumn = "name";
        $scope.reverseSort = false;
        $scope.sortData = function (column) {
            $scope.reverseSort = ($scope.sortColumn == column) ? !$scope.reverseSort : false;
            $scope.sortColumn = column;
        }
        $scope.getSortClass = function (column) {
            if ($scope.sortColumn == column) {
                return $scope.reverseSort ? 'arrow-down' : 'arrow-up';
            }
            return '';
        }
    });
```

### title
```html
```
```javascript
```

