<!--  http://www.w3schools.com/angular/default.asp  -->

<p>Name : <input type="text" ng-model="name"></p>
<h1>Hello {{name}}</h1>
  
<!----------------------------------------------------- INTRO ----------------------------------------------------->
      The ng-app directive defines an AngularJS application.
      The ng-model directive binds the value of HTML controls (input, select, textarea) to application data.
      The ng-bind directive binds application data to the HTML view. 
      
<div ng-app="" ng-init="firstName='John'">
<p>The name is <span ng-bind="firstName"></span></p>
</div>

<p>Name: <input type="text" ng-model="name"></p>
<p>{{name}}</p>

<div ng-app="myApp" ng-controller="myCtrl">
First Name: <input type="text" ng-model="firstName"><br> Last Name: <input type="text" ng-model="lastName"><br> <br>
Full Name: {{firstName + " " + lastName}}
</div>
<script>
var app = angular.module('myApp', []);        // AngularJS modules define applications:
app.controller('myCtrl', function($scope) {   // AngularJS controllers control applications:
    $scope.firstName= "John";
    $scope.lastName= "Doe";
});
</script>

<!----------------------------------------------------- EXPRESSIONS ----------------------------------------------------->
AngularJS expressions can be written inside double braces:{{ expression }} AngularJS expressions can also be written inside a directive: ng-bind="expression"

<p>My first expression: {{ 5 + 5 }}</p>  
  
<div ng-app="" ng-init="myCol='lightblue'">
<input style="background-color:{{myCol}}" ng-model="myCol" value="{{myCol}}">  </div>

The ng-model directive binds the value of HTML controls (input, select, textarea) to application data.
The ng-model directive can also:
Provide type validation for application data (number, email, required).
Provide status for application data (invalid, dirty, touched, error).
Provide CSS classes for HTML elements.
Bind HTML elements to HTML forms.
  
<div ng-app="" ng-init="quantity=1;cost=5">
<p>Total in dollar: {{ quantity * cost }}</p> </div>
  
<div ng-app="" ng-init="quantity=1;cost=5">
<p>Total in dollar: <span ng-bind="quantity * cost"></span></p>  </div>
  
<div ng-app="" ng-init="firstName='John';lastName='Doe'">
<p>The name is {{ firstName + " " + lastName }}</p>  </div>
  
<div ng-app="" ng-init="firstName='John';lastName='Doe'">
<p>The name is <span ng-bind="firstName + ' ' + lastName"></span></p> </div>
  
<div ng-app="" ng-init="person={firstName:'John',lastName:'Doe'}">
<p>Object name is {{ person.lastName }}</p> </div>
  
<div ng-app="" ng-init="person={firstName:'John',lastName:'Doe'}">
<p>Object name is <span ng-bind="person.lastName"></span></p> </div>

<div ng-app="" ng-init="points=[1,15,19,2,40]">
<p>The third result is {{ points[2] }}</p> </div>
  
<div ng-app="" ng-init="points=[1,15,19,2,40]">
<p>The third result is <span ng-bind="points[2]"></span></p> </div>
  
<!----------------------------------------------------- MODULES ----------------------------------------------------->
  
<div ng-app="myApp" ng-controller="myCtrl">
{{ firstName + " " + lastName }} </div>

<script>
var app = angular.module("myApp", []);
app.controller("myCtrl", function($scope) {
    $scope.firstName = "John";
    $scope.lastName = "Doe";
}); </script>
  
qwe
<div ng-app="myApp" w3-test-directive></div>
asd
<script>
var app = angular.module("myApp", []);
app.directive("w3TestDirective", function() {
    return {
        template : "I was made in a directive constructor!"
    };
}); </script>
 
The [] parameter in the module definition can be used to define dependent modules.
Without the [] parameter, you are not creating a new module, but retrieving an existing one.
  
Functions can Pollute the Global Namespace
Global functions should be avoided in JavaScript. They can easily be overwritten or destroyed by other scripts.
AngularJS modules reduces this problem, by keeping all functions local to the module.
  
<!----------------------------------------------------- DIRECTIVES ----------------------------------------------------->
  AngularJS lets you extend HTML with new attributes called Directives.
  AngularJS has a set of built-in directives which offers functionality to your applications.
  AngularJS also lets you define your own directives.
  http://www.w3schools.com/angular/angular_ref_directives.asp
  
<div ng-app="" ng-init="quantity=1;price=5">
Quantity: <input type="number"	ng-model="quantity">
Costs:    <input type="number" ng-model="price">
Total in dollar: {{ quantity * price }} </div>
  
Repeating HTML Elements:  
<div ng-app="" ng-init="names=['Jani','Hege','Kai']">
  <ul>
    <li ng-repeat="x in names">
      {{ x }}
    </li>
  </ul>
</div>
  
The ng-repeat directive used on an array of objects:  
<div ng-app="" ng-init="names=[ {name:'Jani',country:'Norway'}, {name:'Hege',country:'Sweden'}, {name:'Kai',country:'Denmark'}]">
  <ul>
    <li ng-repeat="x	in names">
      {{ x.name + ', ' + x.country }}
    </li>
  </ul>
</div>
  

You can invoke a directive by using: Element name, Attribute, Class, Comment
<w3-test-directive></w3-test-directive>
QWE
<script>
var app = angular.module("myApp", []);
app.directive("w3TestDirective", function() {
    return {
        template : "<h1>Made by a directive!</h1>"
    };
}); </script>

Element name: <w3-test-directive></w3-test-directive>
Attribute:    <div w3-test-directive></div>
Class:        <div class="w3-test-directive"></div>
Comment:      <!-- directive: w3-test-directive -->
  
The legal restrict values are: (By default the value is EA)
E for Element name
A for Attribute
C for Class
M for Comment
By adding a restrict property with the value "A", the directive can only be invoked by attributes: 
<script>  return {
            restrict : "A",
            template : "<h1>Made by a directive!</h1>"
          }; </script>
          
<!----------------------------------------------------- NG-MODEL DIRECTIVE ----------------------------------------------------->

<div ng-app="myApp" ng-controller="myCtrl">
Name: <input ng-model="name">
<h1>You entered: {{name}}</h1></div>
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope) {
    $scope.name = "John Doe";
}); </script>

Validation:
<form ng-app="" name="myForm">
    Email: <input type="email" name="myAddress" ng-model="text">
           <span ng-show="myForm.myAddress.$error.email">Not a valid e-mail address</span>
</form>

Application Status. The ng-model directive can provide status for application data (invalid, dirty, touched, error):
<form ng-app="" name="myForm" ng-init="myText = 'post@myweb.com'">
    Email:
    <input type="email" name="myAddress" ng-model="myText" required>
    {{myForm.myAddress.$valid}}
    {{myForm.myAddress.$dirty}}
    {{myForm.myAddress.$touched}}
</form>

The ng-model directive provides CSS classes for HTML elements, depending on their status:
<style>
input.ng-invalid {
    background-color: red;
}
</style>
<form ng-app="" name="myForm">
    Enter your name: <input name="myName" ng-model="myText" required>
</form>

The ng-model directive adds/removes the following classes, according to the status of the form field:
ng-empty, ng-not-empty, ng-touched, ng-untouched, ng-valid, ng-invalid, ng-dirty, ng-pending, ng-pristine

<!----------------------------------------------------- DATA BINDING ----------------------------------------------------->
Two-way Binding: When data in the model changes, the view reflects the change, and when data in the view changes, the model is updated as well.
Data binding in AngularJS is the synchronization between the model and the view.
The HTML container where the AngularJS application is displayed, is called the view.
The view has access to the model, and there are several ways of displaying model data in the view.
You can use the ng-bind directive, which will bind the innerHTML of the element to the specified model property:
  
<div ng-app="myApp" ng-controller="myCtrl">
    <p ng-bind="firstname"></p>
    <p>First name: {{firstname}}</p>
</div>
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope) {
    $scope.firstname = "John";
    $scope.lastname = "Doe";    
});</script>
  
Or you can use the ng-model directive on HTML controls to bind the model to the view.
Use the ng-model directive to bind data from the model to the view on HTML controls (input, select, textarea)
The ng-model directive provides a two-way binding between the model and the view.
<input ng-model="firstname">

Applications in AngularJS are controlled by controllers. Because of the immediate synchronization of the model and the view,
the controller can be completely separated from the view, and simply concentrate on the model data. Thanks to the data binding in AngularJS, the view will reflect any changes made in the controller.
<h1 ng-click="changeName()">{{firstname}}</h1>  
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope) {
    $scope.changeName = function() {
        $scope.firstname = "Nelly";
    }
}); </script>
  
<!----------------------------------------------------- CONTROLLERS ----------------------------------------------------->
AngularJS controllers control the data of AngularJS applications. AngularJS controllers are regular JavaScript Objects.
AngularJS applications are controlled by controllers.
The ng-controller directive defines the application controller.
A controller is a JavaScript Object, created by a standard JavaScript object constructor.

<div ng-app="myApp" ng-controller="myCtrl">
First Name: <input type="text" ng-model="firstName"><br>
Last Name: <input type="text" ng-model="lastName"><br> <br>
Full Name: {{firstName + " " + lastName}}
Full Name: {{fullName()}} <!-- A controller can also have methods (variables as functions): -->
</div>
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope) {
    $scope.firstName = "John";
    $scope.lastName = "Doe";
    $scope.fullName = function() {
        return $scope.firstName + " " + $scope.lastName;
    };    
}); </script>

The AngularJS application is defined by  ng-app="myApp". The application runs inside the div.
The ng-controller="myCtrl" attribute is an AngularJS directive. It defines a controller.
The myCtrl function is a JavaScript function.
AngularJS will invoke the controller with a $scope object.
In AngularJS, $scope is the application object (the owner of application variables and functions).
The controller creates two properties (variables) in the scope (firstName and lastName).
The ng-model directives bind the input fields to the controller properties (firstName and lastName).
    
<!----------------------------------------------------- SCOPE ----------------------------------------------------->
The scope is the binding part between the HTML (view) and the JavaScript (controller).
The scope is an object with the available properties and methods.
The scope is available for both the view and the controller.
When you make a controller in AngularJS, you pass the $scope object as an argument.
When adding properties to the $scope object in the controller, the view (HTML) gets access to these properties.
In the view, you do not use the prefix $scope, you just refer to a propertyname, like {{carname}}

<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope) {
    $scope.carname = "Volvo";
}); </script>
  
If we consider an AngularJS application to consist of:
View, which is the HTML.
Model, which is the data available for the current view.
Controller, which is the JavaScript function that makes/changes/removes/controls the data.
Then the scope is the Model.
The scope is a JavaScript object with properties and methods, which are available for both the view and the controller.
  
If you make changes in the view, the model and the controller will be updated:
<input ng-model="name">
<h1>My name is {{name}}</h1>
$scope.name = "John Doe";

When dealing with the ng-repeat directive, each repetition has access to the current repetition object:
Each li element has access to the current repetition object, in this case a string, which is referred to by using x.
<ul> <li ng-repeat="x in names">{{x}}</li> </ul>
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope) {
    $scope.names = ["Emil", "Tobias", "Linus"];
});</script>
  
Root Scope: All applications have a $rootScope which is the scope created on the HTML element that contains the ng-app directive.
The rootScope is available in the entire application.
If a variable has the same name in both the current scope and in the rootScope, the application use the one in the current scope.


<h1>The rootScope's favorite color: {{color}}</h1>
<div ng-controller="myCtrl">
    <h1>The scope of the controller's favorite color: {{color}}</h1>
</div>
<h1>The rootScope's favorite color is still: {{color}}</h1>
<script>
var app = angular.module('myApp', []);
app.run(function($rootScope) {
    $rootScope.color = 'blue';
});
app.controller('myCtrl', function($scope) {
    $scope.color = "red";
});</script>
  
<!----------------------------------------------------- FILTERS ----------------------------------------------------->
AngularJS provides filters to transform data:
currency Format a number to a currency format.
date Format a date to a specified format.
filter Select a subset of items from an array.
json Format an object to a JSON string.
limitTo Limits an array/string, into a specified number of elements/characters.
lowercase Format a string to lower case.
number Format a number to a string.
orderBy Orders an array by an expression.
uppercase Format a string to upper case
<script>
angular.module('myApp', []).controller('namesCtrl', function($scope) {
    $scope.names = [
        {name:'Jani',country:'Norway'},
        {name:'Carl',country:'Sweden'},
        {name:'Margareth',country:'England'},
        {name:'Hege',country:'Norway'},
        {name:'Joe',country:'Denmark'},
        {name:'Gustav',country:'Sweden'},
        {name:'Birgit',country:'Denmark'},
        {name:'Mary',country:'England'},
        {name:'Kai',country:'Norway'}
        ];
});</script>

<div ng-app="myApp" ng-controller="namesCtrl">
<ul>
  <li ng-repeat="x in names | orderBy:'country'">
    {{ x.name + ', ' + x.country }}
  </li>
</ul>

Return the names that contains the letter "i":
<ul>
  <li ng-repeat="x in names | filter : 'i'">
    {{ x }}
  </li>
</ul>
  
Filter an Array Based on User Input
<input type="text" ng-model="test">
<ul>
  <li ng-repeat="x in names | filter : test">
    {{ x }}
  </li>
</ul>

By adding the ng-click directive on the table headers, we can run a function that changes the sorting order of the array:  
<div ng-app="myApp" ng-controller="namesCtrl">
  <table border="1" width="100%">
    <tr>
      <th ng-click="orderByMe('name')">Name</th>
      <th ng-click="orderByMe('country')">Country</th>
    </tr>
    <tr ng-repeat="x in names | orderBy:myOrderBy">
      <td>{{x.name}}</td>
      <td>{{x.country}}</td>
    </tr>
  </table>
</div>
<script>
angular.module('myApp', []).controller('namesCtrl', function($scope) {
    $scope.names = [
        {name:'Jani',country:'Norway'},
                 . . .
        {name:'Kai',country:'Norway'} ];
    $scope.orderByMe = function(x) {
        $scope.myOrderBy = x; }
});</script>
  
Custom Filters:
<ul ng-app="myApp" ng-controller="namesCtrl">
    <li ng-repeat="x in names">
        {{x | myFormat}}
    </li>
</ul>
<script>
var app = angular.module('myApp', []);
app.filter('myFormat', function() {
    return function(x) {
        var i, c, txt = "";
        x = x.split("")
        for (i = 0; i < x.length; i++) {
            c = x[i];
            if (i % 2 == 0) {
                c = c.toUpperCase();
            }
            txt += c;
        }
        return txt;
    };
});
app.controller('namesCtrl', function($scope) {
    $scope.names = ['Jani', 'Carl', 'Margareth', 'Hege', 'Joe', 'Gustav', 'Birgit', 'Mary', 'Kai'];
});</script>
  
<!----------------------------------------------------- SERVICES ----------------------------------------------------->
In AngularJS you can make your own service, or use one of the many built-in services.
In AngularJS, a service is a function, or object, that is available for, and limited to, your AngularJS application.
AngularJS has about 30 built-in services. One of them is the $location service.
The $location service has methods which return information about the location of the current web page:

{{myUrl}}
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope, $location) {
    $scope.myUrl = $location.absUrl();
}); </script>
  
The $http service is one of the most common used services in AngularJS applications. The service makes a request to the server, and lets your application handle the response.
{{myWelcome}}
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope, $http) {
  $http.get("welcome.htm").then(function (response) {
      $scope.myWelcome = response.data;
  });
}); </script>
  
Display a new message after two seconds:
{{myHeader}}
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope, $timeout) {
  $scope.myHeader = "Hello World!";
  $timeout(function () {
      $scope.myHeader = "How are you today?";
  }, 2000);
}); </script>
  
Display the time every second:
{{theTime}}
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope, $interval) {
  $scope.theTime = new Date().toLocaleTimeString();
  $interval(function () {
      $scope.theTime = new Date().toLocaleTimeString();
  }, 1000);
}); </script>
  
Create Your Own Service
{{255 | myFormat}}
<script>
var app = angular.module('myApp', []);
// To create your own service, connect your service to the module:
// Create a service named hexafy:
app.service('hexafy', function() {
    this.myFunc = function (x) {
        return x.toString(16);
    }
});
// To use your custom made service, add it as a dependency when defining the filter
app.filter('myFormat',['hexafy', function(hexafy) {
    return function(x) {
        return hexafy.myFunc(x);
    };
}]);</script>

<!----------------------------------------------------- $HTTP ----------------------------------------------------->
AngularJS $http service makes a request to the server, and returns a response.

{{myWelcome}}
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope, $http) {
    $http.get("welcome.htm")
    .then(function(response) {
        $scope.myWelcome = response.data;
    });
});</script>

The .get method is a shortcut method of the $http service. There are several shortcut methods:
.delete(), .get(), .head(), .jsonp(), .patch(), .post(), .put()


<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope, $http) {
  $http({
    method : "GET",
    url : "welcome.htm"
  }).then(function mySucces(response) { //First function handles success
      $scope.myWelcome = response.data;
      $scope.statuscode = response.status;
      $scope.statustext = response.statusText;         
    }, function myError(response) {    //Second function handles error
      $scope.content = "Something went wrong";
      $scope.myWelcome = response.statusText;
  });
}); </script>

    JSON
The data you get from the response is expected to be in JSON format.
JSON is a great way of transporting data, and it is easy to use within AngularJS, or any other JavaScript.
Example: On the server we have a file that returns a JSON object containing 15 customers, all wrapped in array called records.

<div ng-app="myApp" ng-controller="customersCtrl"> 
  <ul>
    <li ng-repeat="x in myData">
      {{ x.Name + ', ' + x.Country }}
    </li>
  </ul>
</div>
<script>
var app = angular.module('myApp', []);
app.controller('customersCtrl', function($scope, $http) {
  $http.get("customers.php").then(function (response) { // http://www.w3schools.com/angular/customers.php
      $scope.myData = response.data.records;
  });
}); </script>

<!----------------------------------------------------- TABLES ----------------------------------------------------->
The ng-repeat directive is perfect for displaying tables.
<style>
table, th , td  {
  border: 1px solid grey;
  border-collapse: collapse;
  padding: 5px;
}
table tr:nth-child(odd)	{
  background-color: #f1f1f1;
}
table tr:nth-child(even) {
  background-color: #ffffff;
}
</style>
<div ng-app="myApp" ng-controller="customersCtrl"> 
<table>
  <tr ng-repeat="x in names | orderBy : 'Country'">
    <td>{{ $index + 1 }}</td>  
    <td>{{ x.Name }}</td>
    <td>{{ x.Country | uppercase }}</td>
  </tr>
</table>
</div>
<script>
var app = angular.module('myApp', []);
app.controller('customersCtrl', function($scope, $http) {
    $http.get("http://www.w3schools.com/angular/customers.php")
    .then(function (response) {$scope.names = response.data.records;});
});</script>

even odd
<table>
  <tr ng-repeat="x in names">
    <td ng-if="$odd" style="background-color:#f1f1f1">
    {{ x.Name }}</td>
    <td ng-if="$even">
    {{ x.Name }}</td>
    <td ng-if="$odd" style="background-color:#f1f1f1">
    {{ x.Country }}</td>
    <td ng-if="$even">
    {{ x.Country }}</td>
  </tr>
</table>

<!----------------------------------------------------- SELECT ----------------------------------------------------->
<select>
<option ng-repeat="x in names">{{x}}</option>
</select>

<select ng-model="selectedName" ng-options="x for x in names">
</select>


<select ng-model="selectedCar"> <option ng-repeat="x in cars" value="{{x.model}}">{{x.model}}</option> </select>
You selected: {{selectedCar}}
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope) {
    $scope.cars = [
        {model : "Ford Mustang", color : "red"},
        {model : "Fiat 500", color : "white"},
        {model : "Volvo XC90", color : "black"}
    ];
}); </script>

When using the ng-options directive, the selected value can be an object:
When the selected value can be an object, it can hold more information, and your application can be more flexible.
<select ng-model="selectedCar" ng-options="x.model for x in cars"> </select>
You selected: {{selectedCar.model}}
It's color is: {{selectedCar.color}}

The expression in the ng-options attribute is a bit different for objects:
<select ng-model="selectedCar" ng-options="x for (x, y) in cars"> </select>
You selected: {{selectedCar}}
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope) {
    $scope.cars = {
        car01 : "Ford", // key :value pairs
        car02 : "Fiat",
        car03 : "Volvo"
    }
}); </script>
  
The selected value will always be the value in a key-value pair.
The value in a key-value pair can also be an object:
<select ng-model="selectedCar" ng-options="x for (x, y) in cars"> </select>
You selected: {{selectedCar.brand}}
Model: {{selectedCar.model}}
Color: {{selectedCar.color}}
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope) {
    $scope.cars = {
        car01 : {brand : "Ford", model : "Mustang", color : "red"},
        car02 : {brand : "Fiat", model : "500", color : "white"},
        car03 : {brand : "Volvo", model : "XC90", color : "black"}
    }
});
</script>

The options in the dropdown list does not have to be the key in a key-value pair, it can also be the value, or a property of the value object:
<select ng-model="selectedCar" ng-options="y.brand for (x, y) in cars"></select>
You selected: {{selectedCar.brand}}
Model: {{selectedCar.model}}
Color: {{selectedCar.color}}
<script>
var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope) {
    $scope.cars = {
        car01 : {brand : "Ford", model : "Mustang", color : "red"},
        car02 : {brand : "Fiat", model : "500", color : "white"},
        car03 : {brand : "Volvo", model : "XC90", color : "black"}
    }
}); </script>
  
  