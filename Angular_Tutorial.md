<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/1999/REC-html401-19991224/strict.dtd">
<html>
<head>
<META http-equiv=Content-Type content="text/html; charset=UTF-8">
<title>Exported from Notepad++</title>
<style type="text/css">
span {
	font-family: 'Lucida Console';
	font-size: 12pt;
	color: #BDAE9D;
}
.sc0 {
}
.sc1 {
	color: #3877EB;
}
.sc2 {
	color: #3877EB;
}
.sc3 {
	color: #8AC600;
}
.sc4 {
	color: #8AC600;
}
.sc6 {
	color: #FF8040;
}
.sc8 {
}
.sc9 {
	color: #C0C0C0;
}
.sc11 {
	color: #3877EB;
}
.sc21 {
	color: #55E439;
}
.sc26 {
}
.sc40 {
}
.sc41 {
	color: #0080C0;
}
.sc43 {
	color: #808080;
}
.sc45 {
	color: #FF3A83;
}
.sc46 {
	color: #FFFFFF;
}
.sc47 {
	color: #4EAEEF;
}
.sc48 {
	color: #8AC600;
}
.sc49 {
	color: #8AC600;
}
.sc50 {
	color: #E5C138;
}
</style>
</head>
<body>
<div style="float: left; white-space: pre; line-height: 1; background: #000000; "><span class="sc9">&lt;!--  http://www.w3schools.com/angular/default.asp  --&gt;</span><span class="sc0">

</span><span class="sc1">&lt;p&gt;</span><span class="sc0">Name : </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"text"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"name"</span><span class="sc1">&gt;&lt;/p&gt;</span><span class="sc0">
</span><span class="sc1">&lt;h1&gt;</span><span class="sc0">Hello {{name}}</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
  
</span><span class="sc9">&lt;!----------------------------------------------------- INTRO -----------------------------------------------------&gt;</span><span class="sc0">
      The ng-app directive defines an AngularJS application.
      The ng-model directive binds the value of HTML controls (input, select, textarea) to application data.
      The ng-bind directive binds application data to the HTML view. 
      
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"firstName='John'"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;p&gt;</span><span class="sc0">The name is </span><span class="sc1">&lt;span</span><span class="sc8"> </span><span class="sc4">ng-bind</span><span class="sc8">=</span><span class="sc6">"firstName"</span><span class="sc1">&gt;&lt;/span&gt;&lt;/p&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">

</span><span class="sc1">&lt;p&gt;</span><span class="sc0">Name: </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"text"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"name"</span><span class="sc1">&gt;&lt;/p&gt;</span><span class="sc0">
</span><span class="sc1">&lt;p&gt;</span><span class="sc0">{{name}}</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">

</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"myCtrl"</span><span class="sc1">&gt;</span><span class="sc0">
First Name: </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"text"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"firstName"</span><span class="sc1">&gt;&lt;br&gt;</span><span class="sc0"> Last Name: </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"text"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"lastName"</span><span class="sc1">&gt;&lt;br&gt;</span><span class="sc0"> </span><span class="sc1">&lt;br&gt;</span><span class="sc0">
Full Name: {{firstName + " " + lastName}}
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">        </span><span class="sc43">// AngularJS modules define applications:</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">   </span><span class="sc43">// AngularJS controllers control applications:</span><span class="sc41">
    $</span><span class="sc46">scope.firstName</span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"John"</span><span class="sc50">;</span><span class="sc41">
    $</span><span class="sc46">scope.lastName</span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"Doe"</span><span class="sc50">;</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41">
</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

</span><span class="sc9">&lt;!----------------------------------------------------- EXPRESSIONS -----------------------------------------------------&gt;</span><span class="sc0">
AngularJS expressions can be written inside double braces:{{ expression }} AngularJS expressions can also be written inside a directive: ng-bind="expression"

</span><span class="sc1">&lt;p&gt;</span><span class="sc0">My first expression: {{ 5 + 5 }}</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">  
  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"myCol='lightblue'"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">style</span><span class="sc8">=</span><span class="sc6">"background-color:{{myCol}}"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myCol"</span><span class="sc8"> </span><span class="sc3">value</span><span class="sc8">=</span><span class="sc6">"{{myCol}}"</span><span class="sc1">&gt;</span><span class="sc0">  </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">

The ng-model directive binds the value of HTML controls (input, select, textarea) to application data.
The ng-model directive can also:
Provide type validation for application data (number, email, required).
Provide status for application data (invalid, dirty, touched, error).
Provide CSS classes for HTML elements.
Bind HTML elements to HTML forms.
  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"quantity=1;cost=5"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;p&gt;</span><span class="sc0">Total in dollar: {{ quantity * cost }}</span><span class="sc1">&lt;/p&gt;</span><span class="sc0"> </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"quantity=1;cost=5"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;p&gt;</span><span class="sc0">Total in dollar: </span><span class="sc1">&lt;span</span><span class="sc8"> </span><span class="sc4">ng-bind</span><span class="sc8">=</span><span class="sc6">"quantity * cost"</span><span class="sc1">&gt;&lt;/span&gt;&lt;/p&gt;</span><span class="sc0">  </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"firstName='John';lastName='Doe'"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;p&gt;</span><span class="sc0">The name is {{ firstName + " " + lastName }}</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">  </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"firstName='John';lastName='Doe'"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;p&gt;</span><span class="sc0">The name is </span><span class="sc1">&lt;span</span><span class="sc8"> </span><span class="sc4">ng-bind</span><span class="sc8">=</span><span class="sc6">"firstName + ' ' + lastName"</span><span class="sc1">&gt;&lt;/span&gt;&lt;/p&gt;</span><span class="sc0"> </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"person={firstName:'John',lastName:'Doe'}"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;p&gt;</span><span class="sc0">Object name is {{ person.lastName }}</span><span class="sc1">&lt;/p&gt;</span><span class="sc0"> </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"person={firstName:'John',lastName:'Doe'}"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;p&gt;</span><span class="sc0">Object name is </span><span class="sc1">&lt;span</span><span class="sc8"> </span><span class="sc4">ng-bind</span><span class="sc8">=</span><span class="sc6">"person.lastName"</span><span class="sc1">&gt;&lt;/span&gt;&lt;/p&gt;</span><span class="sc0"> </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">

</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"points=[1,15,19,2,40]"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;p&gt;</span><span class="sc0">The third result is {{ points[2] }}</span><span class="sc1">&lt;/p&gt;</span><span class="sc0"> </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"points=[1,15,19,2,40]"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;p&gt;</span><span class="sc0">The third result is </span><span class="sc1">&lt;span</span><span class="sc8"> </span><span class="sc4">ng-bind</span><span class="sc8">=</span><span class="sc6">"points[2]"</span><span class="sc1">&gt;&lt;/span&gt;&lt;/p&gt;</span><span class="sc0"> </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  
</span><span class="sc9">&lt;!----------------------------------------------------- MODULES -----------------------------------------------------&gt;</span><span class="sc0">
  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"myCtrl"</span><span class="sc1">&gt;</span><span class="sc0">
{{ firstName + " " + lastName }} </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">

</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc48">"myApp"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc48">"myCtrl"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.firstName</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"John"</span><span class="sc50">;</span><span class="sc41">
    $</span><span class="sc46">scope.lastName</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"Doe"</span><span class="sc50">;</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
qwe
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">w3-test-directive</span><span class="sc1">&gt;&lt;/div&gt;</span><span class="sc0">
asd
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc48">"myApp"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.directive</span><span class="sc50">(</span><span class="sc48">"w3TestDirective"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    </span><span class="sc47">return</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        </span><span class="sc46">template</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"I was made in a directive constructor!"</span><span class="sc41">
    </span><span class="sc50">};</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
 
The [] parameter in the module definition can be used to define dependent modules.
Without the [] parameter, you are not creating a new module, but retrieving an existing one.
  
Functions can Pollute the Global Namespace
Global functions should be avoided in JavaScript. They can easily be overwritten or destroyed by other scripts.
AngularJS modules reduces this problem, by keeping all functions local to the module.
  
</span><span class="sc9">&lt;!----------------------------------------------------- DIRECTIVES -----------------------------------------------------&gt;</span><span class="sc0">
  AngularJS lets you extend HTML with new attributes called Directives.
  AngularJS has a set of built-in directives which offers functionality to your applications.
  AngularJS also lets you define your own directives.
  http://www.w3schools.com/angular/angular_ref_directives.asp
  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"quantity=1;price=5"</span><span class="sc1">&gt;</span><span class="sc0">
Quantity: </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"number"</span><span class="sc8">  </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"quantity"</span><span class="sc1">&gt;</span><span class="sc0">
Costs:    </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"number"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"price"</span><span class="sc1">&gt;</span><span class="sc0">
Total in dollar: {{ quantity * price }} </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  
Repeating HTML Elements:  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"names=['Jani','Hege','Kai']"</span><span class="sc1">&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;ul&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;li</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in names"</span><span class="sc1">&gt;</span><span class="sc0">
      {{ x }}
    </span><span class="sc1">&lt;/li&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/ul&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  
The ng-repeat directive used on an array of objects:  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"names=[ {name:'Jani',country:'Norway'}, {name:'Hege',country:'Sweden'}, {name:'Kai',country:'Denmark'}]"</span><span class="sc1">&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;ul&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;li</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x    in names"</span><span class="sc1">&gt;</span><span class="sc0">
      {{ x.name + ', ' + x.country }}
    </span><span class="sc1">&lt;/li&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/ul&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  

You can invoke a directive by using: Element name, Attribute, Class, Comment
</span><span class="sc2">&lt;w3-test-directive&gt;&lt;/w3-test-directive&gt;</span><span class="sc0">
QWE
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc48">"myApp"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.directive</span><span class="sc50">(</span><span class="sc48">"w3TestDirective"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    </span><span class="sc47">return</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        </span><span class="sc46">template</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"&lt;h1&gt;Made by a directive!&lt;/h1&gt;"</span><span class="sc41">
    </span><span class="sc50">};</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

Element name: </span><span class="sc2">&lt;w3-test-directive&gt;&lt;/w3-test-directive&gt;</span><span class="sc0">
Attribute:    </span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">w3-test-directive</span><span class="sc1">&gt;&lt;/div&gt;</span><span class="sc0">
Class:        </span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-test-directive"</span><span class="sc1">&gt;&lt;/div&gt;</span><span class="sc0">
Comment:      </span><span class="sc9">&lt;!-- directive: w3-test-directive --&gt;</span><span class="sc0">
  
The legal restrict values are: (By default the value is EA)
E for Element name
A for Attribute
C for Class
M for Comment
By adding a restrict property with the value "A", the directive can only be invoked by attributes: 
</span><span class="sc1">&lt;script&gt;</span><span class="sc41">  </span><span class="sc47">return</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
            </span><span class="sc46">restrict</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"A"</span><span class="sc50">,</span><span class="sc41">
            </span><span class="sc46">template</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"&lt;h1&gt;Made by a directive!&lt;/h1&gt;"</span><span class="sc41">
          </span><span class="sc50">};</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
          
</span><span class="sc9">&lt;!----------------------------------------------------- NG-MODEL DIRECTIVE -----------------------------------------------------&gt;</span><span class="sc0">

</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"myCtrl"</span><span class="sc1">&gt;</span><span class="sc0">
Name: </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"name"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;h1&gt;</span><span class="sc0">You entered: {{name}}</span><span class="sc1">&lt;/h1&gt;&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.name</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"John Doe"</span><span class="sc50">;</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

Validation:
</span><span class="sc1">&lt;form</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myForm"</span><span class="sc1">&gt;</span><span class="sc0">
    Email: </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"email"</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myAddress"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"text"</span><span class="sc1">&gt;</span><span class="sc0">
           </span><span class="sc1">&lt;span</span><span class="sc8"> </span><span class="sc4">ng-show</span><span class="sc8">=</span><span class="sc6">"myForm.myAddress.$error.email"</span><span class="sc1">&gt;</span><span class="sc0">Not a valid e-mail address</span><span class="sc1">&lt;/span&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/form&gt;</span><span class="sc0">

Application Status. The ng-model directive can provide status for application data (invalid, dirty, touched, error):
</span><span class="sc1">&lt;form</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myForm"</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"myText = 'post@myweb.com'"</span><span class="sc1">&gt;</span><span class="sc0">
    Email:
    </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"email"</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myAddress"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myText"</span><span class="sc8"> </span><span class="sc4">required</span><span class="sc1">&gt;</span><span class="sc0">
    {{myForm.myAddress.$valid}}
    {{myForm.myAddress.$dirty}}
    {{myForm.myAddress.$touched}}
</span><span class="sc1">&lt;/form&gt;</span><span class="sc0">

The ng-model directive provides CSS classes for HTML elements, depending on their status:
</span><span class="sc1">&lt;style&gt;</span><span class="sc0">
input.ng-invalid {
    background-color: red;
}
</span><span class="sc1">&lt;/style&gt;</span><span class="sc0">
</span><span class="sc1">&lt;form</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myForm"</span><span class="sc1">&gt;</span><span class="sc0">
    Enter your name: </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myName"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myText"</span><span class="sc8"> </span><span class="sc4">required</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/form&gt;</span><span class="sc0">

The ng-model directive adds/removes the following classes, according to the status of the form field:
ng-empty, ng-not-empty, ng-touched, ng-untouched, ng-valid, ng-invalid, ng-dirty, ng-pending, ng-pristine

</span><span class="sc9">&lt;!----------------------------------------------------- DATA BINDING -----------------------------------------------------&gt;</span><span class="sc0">
Two-way Binding: When data in the model changes, the view reflects the change, and when data in the view changes, the model is updated as well.
Data binding in AngularJS is the synchronization between the model and the view.
The HTML container where the AngularJS application is displayed, is called the view.
The view has access to the model, and there are several ways of displaying model data in the view.
You can use the ng-bind directive, which will bind the innerHTML of the element to the specified model property:
  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"myCtrl"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;p</span><span class="sc8"> </span><span class="sc4">ng-bind</span><span class="sc8">=</span><span class="sc6">"firstname"</span><span class="sc1">&gt;&lt;/p&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;p&gt;</span><span class="sc0">First name: {{firstname}}</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.firstname</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"John"</span><span class="sc50">;</span><span class="sc41">
    $</span><span class="sc46">scope.lastname</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"Doe"</span><span class="sc50">;</span><span class="sc41">    
</span><span class="sc50">});</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
Or you can use the ng-model directive on HTML controls to bind the model to the view.
Use the ng-model directive to bind data from the model to the view on HTML controls (input, select, textarea)
The ng-model directive provides a two-way binding between the model and the view.
</span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"firstname"</span><span class="sc1">&gt;</span><span class="sc0">

Applications in AngularJS are controlled by controllers. Because of the immediate synchronization of the model and the view,
the controller can be completely separated from the view, and simply concentrate on the model data. Thanks to the data binding in AngularJS, the view will reflect any changes made in the controller.
</span><span class="sc1">&lt;h1</span><span class="sc8"> </span><span class="sc4">ng-click</span><span class="sc8">=</span><span class="sc6">"changeName()"</span><span class="sc1">&gt;</span><span class="sc0">{{firstname}}</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">  
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.changeName</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        $</span><span class="sc46">scope.firstname</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"Nelly"</span><span class="sc50">;</span><span class="sc41">
    </span><span class="sc50">}</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
</span><span class="sc9">&lt;!----------------------------------------------------- CONTROLLERS -----------------------------------------------------&gt;</span><span class="sc0">
AngularJS controllers control the data of AngularJS applications. AngularJS controllers are regular JavaScript Objects.
AngularJS applications are controlled by controllers.
The ng-controller directive defines the application controller.
A controller is a JavaScript Object, created by a standard JavaScript object constructor.

</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"myCtrl"</span><span class="sc1">&gt;</span><span class="sc0">
First Name: </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"text"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"firstName"</span><span class="sc1">&gt;&lt;br&gt;</span><span class="sc0">
Last Name: </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"text"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"lastName"</span><span class="sc1">&gt;&lt;br&gt;</span><span class="sc0"> </span><span class="sc1">&lt;br&gt;</span><span class="sc0">
Full Name: {{firstName + " " + lastName}}
Full Name: {{fullName()}} </span><span class="sc9">&lt;!-- A controller can also have methods (variables as functions): --&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.firstName</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"John"</span><span class="sc50">;</span><span class="sc41">
    $</span><span class="sc46">scope.lastName</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"Doe"</span><span class="sc50">;</span><span class="sc41">
    $</span><span class="sc46">scope.fullName</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        </span><span class="sc47">return</span><span class="sc41"> $</span><span class="sc46">scope.firstName</span><span class="sc41"> </span><span class="sc50">+</span><span class="sc41"> </span><span class="sc48">" "</span><span class="sc41"> </span><span class="sc50">+</span><span class="sc41"> $</span><span class="sc46">scope.lastName</span><span class="sc50">;</span><span class="sc41">
    </span><span class="sc50">};</span><span class="sc41">    
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

The AngularJS application is defined by  ng-app="myApp". The application runs inside the div.
The ng-controller="myCtrl" attribute is an AngularJS directive. It defines a controller.
The myCtrl function is a JavaScript function.
AngularJS will invoke the controller with a $scope object.
In AngularJS, $scope is the application object (the owner of application variables and functions).
The controller creates two properties (variables) in the scope (firstName and lastName).
The ng-model directives bind the input fields to the controller properties (firstName and lastName).
    
</span><span class="sc9">&lt;!----------------------------------------------------- SCOPE -----------------------------------------------------&gt;</span><span class="sc0">
The scope is the binding part between the HTML (view) and the JavaScript (controller).
The scope is an object with the available properties and methods.
The scope is available for both the view and the controller.
When you make a controller in AngularJS, you pass the $scope object as an argument.
When adding properties to the $scope object in the controller, the view (HTML) gets access to these properties.
In the view, you do not use the prefix $scope, you just refer to a propertyname, like {{carname}}

</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.carname</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"Volvo"</span><span class="sc50">;</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
If we consider an AngularJS application to consist of:
View, which is the HTML.
Model, which is the data available for the current view.
Controller, which is the JavaScript function that makes/changes/removes/controls the data.
Then the scope is the Model.
The scope is a JavaScript object with properties and methods, which are available for both the view and the controller.
  
If you make changes in the view, the model and the controller will be updated:
</span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"name"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;h1&gt;</span><span class="sc0">My name is {{name}}</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
$scope.name = "John Doe";

When dealing with the ng-repeat directive, each repetition has access to the current repetition object:
Each li element has access to the current repetition object, in this case a string, which is referred to by using x.
</span><span class="sc1">&lt;ul&gt;</span><span class="sc0"> </span><span class="sc1">&lt;li</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in names"</span><span class="sc1">&gt;</span><span class="sc0">{{x}}</span><span class="sc1">&lt;/li&gt;</span><span class="sc0"> </span><span class="sc1">&lt;/ul&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.names</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc50">[</span><span class="sc48">"Emil"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc48">"Tobias"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc48">"Linus"</span><span class="sc50">];</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
Root Scope: All applications have a $rootScope which is the scope created on the HTML element that contains the ng-app directive.
The rootScope is available in the entire application.
If a variable has the same name in both the current scope and in the rootScope, the application use the one in the current scope.


</span><span class="sc1">&lt;h1&gt;</span><span class="sc0">The rootScope's favorite color: {{color}}</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"myCtrl"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;h1&gt;</span><span class="sc0">The scope of the controller's favorite color: {{color}}</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;h1&gt;</span><span class="sc0">The rootScope's favorite color is still: {{color}}</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.run</span><span class="sc50">(</span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">rootScope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">rootScope.color</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc49">'blue'</span><span class="sc50">;</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.color</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"red"</span><span class="sc50">;</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
</span><span class="sc9">&lt;!----------------------------------------------------- FILTERS -----------------------------------------------------&gt;</span><span class="sc0">
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
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]).</span><span class="sc46">controller</span><span class="sc50">(</span><span class="sc49">'namesCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.names</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc50">[</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">name</span><span class="sc50">:</span><span class="sc49">'Jani'</span><span class="sc50">,</span><span class="sc46">country</span><span class="sc50">:</span><span class="sc49">'Norway'</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">name</span><span class="sc50">:</span><span class="sc49">'Carl'</span><span class="sc50">,</span><span class="sc46">country</span><span class="sc50">:</span><span class="sc49">'Sweden'</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">name</span><span class="sc50">:</span><span class="sc49">'Margareth'</span><span class="sc50">,</span><span class="sc46">country</span><span class="sc50">:</span><span class="sc49">'England'</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">name</span><span class="sc50">:</span><span class="sc49">'Hege'</span><span class="sc50">,</span><span class="sc46">country</span><span class="sc50">:</span><span class="sc49">'Norway'</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">name</span><span class="sc50">:</span><span class="sc49">'Joe'</span><span class="sc50">,</span><span class="sc46">country</span><span class="sc50">:</span><span class="sc49">'Denmark'</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">name</span><span class="sc50">:</span><span class="sc49">'Gustav'</span><span class="sc50">,</span><span class="sc46">country</span><span class="sc50">:</span><span class="sc49">'Sweden'</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">name</span><span class="sc50">:</span><span class="sc49">'Birgit'</span><span class="sc50">,</span><span class="sc46">country</span><span class="sc50">:</span><span class="sc49">'Denmark'</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">name</span><span class="sc50">:</span><span class="sc49">'Mary'</span><span class="sc50">,</span><span class="sc46">country</span><span class="sc50">:</span><span class="sc49">'England'</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">name</span><span class="sc50">:</span><span class="sc49">'Kai'</span><span class="sc50">,</span><span class="sc46">country</span><span class="sc50">:</span><span class="sc49">'Norway'</span><span class="sc50">}</span><span class="sc41">
        </span><span class="sc50">];</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"namesCtrl"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;ul&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;li</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in names | orderBy:'country'"</span><span class="sc1">&gt;</span><span class="sc0">
    {{ x.name + ', ' + x.country }}
  </span><span class="sc1">&lt;/li&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/ul&gt;</span><span class="sc0">

Return the names that contains the letter "i":
</span><span class="sc1">&lt;ul&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;li</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in names | filter : 'i'"</span><span class="sc1">&gt;</span><span class="sc0">
    {{ x }}
  </span><span class="sc1">&lt;/li&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/ul&gt;</span><span class="sc0">
  
Filter an Array Based on User Input
</span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"text"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"test"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;ul&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;li</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in names | filter : test"</span><span class="sc1">&gt;</span><span class="sc0">
    {{ x }}
  </span><span class="sc1">&lt;/li&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/ul&gt;</span><span class="sc0">

By adding the ng-click directive on the table headers, we can run a function that changes the sorting order of the array:  
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"namesCtrl"</span><span class="sc1">&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;table</span><span class="sc8"> </span><span class="sc3">border</span><span class="sc8">=</span><span class="sc6">"1"</span><span class="sc8"> </span><span class="sc3">width</span><span class="sc8">=</span><span class="sc6">"100%"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;tr&gt;</span><span class="sc0">
      </span><span class="sc1">&lt;th</span><span class="sc8"> </span><span class="sc4">ng-click</span><span class="sc8">=</span><span class="sc6">"orderByMe('name')"</span><span class="sc1">&gt;</span><span class="sc0">Name</span><span class="sc1">&lt;/th&gt;</span><span class="sc0">
      </span><span class="sc1">&lt;th</span><span class="sc8"> </span><span class="sc4">ng-click</span><span class="sc8">=</span><span class="sc6">"orderByMe('country')"</span><span class="sc1">&gt;</span><span class="sc0">Country</span><span class="sc1">&lt;/th&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;/tr&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;tr</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in names | orderBy:myOrderBy"</span><span class="sc1">&gt;</span><span class="sc0">
      </span><span class="sc1">&lt;td&gt;</span><span class="sc0">{{x.name}}</span><span class="sc1">&lt;/td&gt;</span><span class="sc0">
      </span><span class="sc1">&lt;td&gt;</span><span class="sc0">{{x.country}}</span><span class="sc1">&lt;/td&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;/tr&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/table&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]).</span><span class="sc46">controller</span><span class="sc50">(</span><span class="sc49">'namesCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.names</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc50">[</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">name</span><span class="sc50">:</span><span class="sc49">'Jani'</span><span class="sc50">,</span><span class="sc46">country</span><span class="sc50">:</span><span class="sc49">'Norway'</span><span class="sc50">},</span><span class="sc41">
                 </span><span class="sc50">.</span><span class="sc41"> </span><span class="sc50">.</span><span class="sc41"> </span><span class="sc50">.</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">name</span><span class="sc50">:</span><span class="sc49">'Kai'</span><span class="sc50">,</span><span class="sc46">country</span><span class="sc50">:</span><span class="sc49">'Norway'</span><span class="sc50">}</span><span class="sc41"> </span><span class="sc50">];</span><span class="sc41">
    $</span><span class="sc46">scope.orderByMe</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc46">x</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        $</span><span class="sc46">scope.myOrderBy</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">x</span><span class="sc50">;</span><span class="sc41"> </span><span class="sc50">}</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
Custom Filters:
</span><span class="sc1">&lt;ul</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"namesCtrl"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;li</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in names"</span><span class="sc1">&gt;</span><span class="sc0">
        {{x | myFormat}}
    </span><span class="sc1">&lt;/li&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/ul&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.filter</span><span class="sc50">(</span><span class="sc49">'myFormat'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    </span><span class="sc47">return</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc46">x</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        </span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">i</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">c</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">txt</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">""</span><span class="sc50">;</span><span class="sc41">
        </span><span class="sc46">x</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">x.split</span><span class="sc50">(</span><span class="sc48">""</span><span class="sc50">)</span><span class="sc41">
        </span><span class="sc47">for</span><span class="sc41"> </span><span class="sc50">(</span><span class="sc46">i</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc45">0</span><span class="sc50">;</span><span class="sc41"> </span><span class="sc46">i</span><span class="sc41"> </span><span class="sc50">&lt;</span><span class="sc41"> </span><span class="sc46">x.length</span><span class="sc50">;</span><span class="sc41"> </span><span class="sc46">i</span><span class="sc50">++)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
            </span><span class="sc46">c</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">x</span><span class="sc50">[</span><span class="sc46">i</span><span class="sc50">];</span><span class="sc41">
            </span><span class="sc47">if</span><span class="sc41"> </span><span class="sc50">(</span><span class="sc46">i</span><span class="sc41"> </span><span class="sc50">%</span><span class="sc41"> </span><span class="sc45">2</span><span class="sc41"> </span><span class="sc50">==</span><span class="sc41"> </span><span class="sc45">0</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                </span><span class="sc46">c</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">c.toUpperCase</span><span class="sc50">();</span><span class="sc41">
            </span><span class="sc50">}</span><span class="sc41">
            </span><span class="sc46">txt</span><span class="sc41"> </span><span class="sc50">+=</span><span class="sc41"> </span><span class="sc46">c</span><span class="sc50">;</span><span class="sc41">
        </span><span class="sc50">}</span><span class="sc41">
        </span><span class="sc47">return</span><span class="sc41"> </span><span class="sc46">txt</span><span class="sc50">;</span><span class="sc41">
    </span><span class="sc50">};</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'namesCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.names</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc50">[</span><span class="sc49">'Jani'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc49">'Carl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc49">'Margareth'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc49">'Hege'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc49">'Joe'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc49">'Gustav'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc49">'Birgit'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc49">'Mary'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc49">'Kai'</span><span class="sc50">];</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
</span><span class="sc9">&lt;!----------------------------------------------------- SERVICES -----------------------------------------------------&gt;</span><span class="sc0">
In AngularJS you can make your own service, or use one of the many built-in services.
In AngularJS, a service is a function, or object, that is available for, and limited to, your AngularJS application.
AngularJS has about 30 built-in services. One of them is the $location service.
The $location service has methods which return information about the location of the current web page:

{{myUrl}}
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">,</span><span class="sc41"> $</span><span class="sc47">location</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.myUrl</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> $</span><span class="sc46">location.absUrl</span><span class="sc50">();</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
The $http service is one of the most common used services in AngularJS applications. The service makes a request to the server, and lets your application handle the response.
{{myWelcome}}
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">,</span><span class="sc41"> $</span><span class="sc46">http</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
  $</span><span class="sc46">http.get</span><span class="sc50">(</span><span class="sc48">"welcome.htm"</span><span class="sc50">).</span><span class="sc46">then</span><span class="sc50">(</span><span class="sc47">function</span><span class="sc41"> </span><span class="sc50">(</span><span class="sc46">response</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
      $</span><span class="sc46">scope.myWelcome</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">response.data</span><span class="sc50">;</span><span class="sc41">
  </span><span class="sc50">});</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
Display a new message after two seconds:
{{myHeader}}
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">,</span><span class="sc41"> $</span><span class="sc46">timeout</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
  $</span><span class="sc46">scope.myHeader</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"Hello World!"</span><span class="sc50">;</span><span class="sc41">
  $</span><span class="sc46">timeout</span><span class="sc50">(</span><span class="sc47">function</span><span class="sc41"> </span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
      $</span><span class="sc46">scope.myHeader</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"How are you today?"</span><span class="sc50">;</span><span class="sc41">
  </span><span class="sc50">},</span><span class="sc41"> </span><span class="sc45">2000</span><span class="sc50">);</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
Display the time every second:
{{theTime}}
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">,</span><span class="sc41"> $</span><span class="sc46">interval</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
  $</span><span class="sc46">scope.theTime</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">new</span><span class="sc41"> </span><span class="sc46">Date</span><span class="sc50">().</span><span class="sc46">toLocaleTimeString</span><span class="sc50">();</span><span class="sc41">
  $</span><span class="sc46">interval</span><span class="sc50">(</span><span class="sc47">function</span><span class="sc41"> </span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
      $</span><span class="sc46">scope.theTime</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">new</span><span class="sc41"> </span><span class="sc46">Date</span><span class="sc50">().</span><span class="sc46">toLocaleTimeString</span><span class="sc50">();</span><span class="sc41">
  </span><span class="sc50">},</span><span class="sc41"> </span><span class="sc45">1000</span><span class="sc50">);</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
Create Your Own Service
{{255 | myFormat}}
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc43">// To create your own service, connect your service to the module:</span><span class="sc41">
</span><span class="sc43">// Create a service named hexafy:</span><span class="sc41">
</span><span class="sc46">app.service</span><span class="sc50">(</span><span class="sc49">'hexafy'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    </span><span class="sc46">this.myFunc</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc41"> </span><span class="sc50">(</span><span class="sc46">x</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        </span><span class="sc47">return</span><span class="sc41"> </span><span class="sc46">x.toString</span><span class="sc50">(</span><span class="sc45">16</span><span class="sc50">);</span><span class="sc41">
    </span><span class="sc50">}</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41">
</span><span class="sc43">// To use your custom made service, add it as a dependency when defining the filter</span><span class="sc41">
</span><span class="sc46">app.filter</span><span class="sc50">(</span><span class="sc49">'myFormat'</span><span class="sc50">,[</span><span class="sc49">'hexafy'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc46">hexafy</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    </span><span class="sc47">return</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc46">x</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        </span><span class="sc47">return</span><span class="sc41"> </span><span class="sc46">hexafy.myFunc</span><span class="sc50">(</span><span class="sc46">x</span><span class="sc50">);</span><span class="sc41">
    </span><span class="sc50">};</span><span class="sc41">
</span><span class="sc50">}]);</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

</span><span class="sc9">&lt;!----------------------------------------------------- $HTTP -----------------------------------------------------&gt;</span><span class="sc0">
AngularJS $http service makes a request to the server, and returns a response.

{{myWelcome}}
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">,</span><span class="sc41"> $</span><span class="sc46">http</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">http.get</span><span class="sc50">(</span><span class="sc48">"welcome.htm"</span><span class="sc50">)</span><span class="sc41">
    </span><span class="sc50">.</span><span class="sc46">then</span><span class="sc50">(</span><span class="sc47">function</span><span class="sc50">(</span><span class="sc46">response</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        $</span><span class="sc46">scope.myWelcome</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">response.data</span><span class="sc50">;</span><span class="sc41">
    </span><span class="sc50">});</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

The .get method is a shortcut method of the $http service. There are several shortcut methods:
.delete(), .get(), .head(), .jsonp(), .patch(), .post(), .put()


</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">,</span><span class="sc41"> $</span><span class="sc46">http</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
  $</span><span class="sc46">http</span><span class="sc50">({</span><span class="sc41">
    </span><span class="sc46">method</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"GET"</span><span class="sc50">,</span><span class="sc41">
    </span><span class="sc46">url</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"welcome.htm"</span><span class="sc41">
  </span><span class="sc50">}).</span><span class="sc46">then</span><span class="sc50">(</span><span class="sc47">function</span><span class="sc41"> </span><span class="sc46">mySucces</span><span class="sc50">(</span><span class="sc46">response</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41"> </span><span class="sc43">//First function handles success</span><span class="sc41">
      $</span><span class="sc46">scope.myWelcome</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">response.data</span><span class="sc50">;</span><span class="sc41">
      $</span><span class="sc46">scope.statuscode</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">response.status</span><span class="sc50">;</span><span class="sc41">
      $</span><span class="sc46">scope.statustext</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">response.statusText</span><span class="sc50">;</span><span class="sc41">         
    </span><span class="sc50">},</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc41"> </span><span class="sc46">myError</span><span class="sc50">(</span><span class="sc46">response</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">    </span><span class="sc43">//Second function handles error</span><span class="sc41">
      $</span><span class="sc46">scope.content</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"Something went wrong"</span><span class="sc50">;</span><span class="sc41">
      $</span><span class="sc46">scope.myWelcome</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">response.statusText</span><span class="sc50">;</span><span class="sc41">
  </span><span class="sc50">});</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

    JSON
The data you get from the response is expected to be in JSON format.
JSON is a great way of transporting data, and it is easy to use within AngularJS, or any other JavaScript.
Example: On the server we have a file that returns a JSON object containing 15 customers, all wrapped in array called records.

</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"customersCtrl"</span><span class="sc1">&gt;</span><span class="sc0"> 
  </span><span class="sc1">&lt;ul&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;li</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in myData"</span><span class="sc1">&gt;</span><span class="sc0">
      {{ x.Name + ', ' + x.Country }}
    </span><span class="sc1">&lt;/li&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/ul&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'customersCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">,</span><span class="sc41"> $</span><span class="sc46">http</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
  $</span><span class="sc46">http.get</span><span class="sc50">(</span><span class="sc48">"customers.php"</span><span class="sc50">).</span><span class="sc46">then</span><span class="sc50">(</span><span class="sc47">function</span><span class="sc41"> </span><span class="sc50">(</span><span class="sc46">response</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41"> </span><span class="sc43">// http://www.w3schools.com/angular/customers.php</span><span class="sc41">
      $</span><span class="sc46">scope.myData</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">response.data.records</span><span class="sc50">;</span><span class="sc41">
  </span><span class="sc50">});</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

</span><span class="sc9">&lt;!----------------------------------------------------- TABLES -----------------------------------------------------&gt;</span><span class="sc0">
The ng-repeat directive is perfect for displaying tables.
</span><span class="sc1">&lt;style&gt;</span><span class="sc0">
table, th , td  {
  border: 1px solid grey;
  border-collapse: collapse;
  padding: 5px;
}
table tr:nth-child(odd) {
  background-color: #f1f1f1;
}
table tr:nth-child(even) {
  background-color: #ffffff;
}
</span><span class="sc1">&lt;/style&gt;</span><span class="sc0">
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"customersCtrl"</span><span class="sc1">&gt;</span><span class="sc0"> 
</span><span class="sc1">&lt;table&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;tr</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in names | orderBy : 'Country'"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;td&gt;</span><span class="sc0">{{ $index + 1 }}</span><span class="sc1">&lt;/td&gt;</span><span class="sc0">  
    </span><span class="sc1">&lt;td&gt;</span><span class="sc0">{{ x.Name }}</span><span class="sc1">&lt;/td&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;td&gt;</span><span class="sc0">{{ x.Country | uppercase }}</span><span class="sc1">&lt;/td&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/tr&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/table&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'customersCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">,</span><span class="sc41"> $</span><span class="sc46">http</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">http.get</span><span class="sc50">(</span><span class="sc48">"http://www.w3schools.com/angular/customers.php"</span><span class="sc50">)</span><span class="sc41">
    </span><span class="sc50">.</span><span class="sc46">then</span><span class="sc50">(</span><span class="sc47">function</span><span class="sc41"> </span><span class="sc50">(</span><span class="sc46">response</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">$</span><span class="sc46">scope.names</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">response.data.records</span><span class="sc50">;});</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

even odd
</span><span class="sc1">&lt;table&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;tr</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in names"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;td</span><span class="sc8"> </span><span class="sc4">ng-if</span><span class="sc8">=</span><span class="sc6">"$odd"</span><span class="sc8"> </span><span class="sc3">style</span><span class="sc8">=</span><span class="sc6">"background-color:#f1f1f1"</span><span class="sc1">&gt;</span><span class="sc0">
    {{ x.Name }}</span><span class="sc1">&lt;/td&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;td</span><span class="sc8"> </span><span class="sc4">ng-if</span><span class="sc8">=</span><span class="sc6">"$even"</span><span class="sc1">&gt;</span><span class="sc0">
    {{ x.Name }}</span><span class="sc1">&lt;/td&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;td</span><span class="sc8"> </span><span class="sc4">ng-if</span><span class="sc8">=</span><span class="sc6">"$odd"</span><span class="sc8"> </span><span class="sc3">style</span><span class="sc8">=</span><span class="sc6">"background-color:#f1f1f1"</span><span class="sc1">&gt;</span><span class="sc0">
    {{ x.Country }}</span><span class="sc1">&lt;/td&gt;</span><span class="sc0">
    {{ x.Country }}</span><span class="sc1">&lt;/td&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;td</span><span class="sc8"> </span><span class="sc4">ng-if</span><span class="sc8">=</span><span class="sc6">"$even"</span><span class="sc1">&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/tr&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/table&gt;</span><span class="sc0">

</span><span class="sc9">&lt;!----------------------------------------------------- SELECT -----------------------------------------------------&gt;</span><span class="sc0">
</span><span class="sc1">&lt;select&gt;</span><span class="sc0">
</span><span class="sc1">&lt;option</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in names"</span><span class="sc1">&gt;</span><span class="sc0">{{x}}</span><span class="sc1">&lt;/option&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/select&gt;</span><span class="sc0">

</span><span class="sc1">&lt;select</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"selectedName"</span><span class="sc8"> </span><span class="sc4">ng-options</span><span class="sc8">=</span><span class="sc6">"x for x in names"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/select&gt;</span><span class="sc0">


</span><span class="sc1">&lt;select</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"selectedCar"</span><span class="sc1">&gt;</span><span class="sc0"> </span><span class="sc1">&lt;option</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in cars"</span><span class="sc8"> </span><span class="sc3">value</span><span class="sc8">=</span><span class="sc6">"{{x.model}}"</span><span class="sc1">&gt;</span><span class="sc0">{{x.model}}</span><span class="sc1">&lt;/option&gt;</span><span class="sc0"> </span><span class="sc1">&lt;/select&gt;</span><span class="sc0">
You selected: {{selectedCar}}
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.cars</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc50">[</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">model</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Ford Mustang"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">color</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"red"</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">model</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Fiat 500"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">color</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"white"</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc50">{</span><span class="sc46">model</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Volvo XC90"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">color</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"black"</span><span class="sc50">}</span><span class="sc41">
    </span><span class="sc50">];</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

When using the ng-options directive, the selected value can be an object:
When the selected value can be an object, it can hold more information, and your application can be more flexible.
</span><span class="sc1">&lt;select</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"selectedCar"</span><span class="sc8"> </span><span class="sc4">ng-options</span><span class="sc8">=</span><span class="sc6">"x.model for x in cars"</span><span class="sc1">&gt;</span><span class="sc0"> </span><span class="sc1">&lt;/select&gt;</span><span class="sc0">
You selected: {{selectedCar.model}}
It's color is: {{selectedCar.color}}

The expression in the ng-options attribute is a bit different for objects:
</span><span class="sc1">&lt;select</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"selectedCar"</span><span class="sc8"> </span><span class="sc4">ng-options</span><span class="sc8">=</span><span class="sc6">"x for (x, y) in cars"</span><span class="sc1">&gt;</span><span class="sc0"> </span><span class="sc1">&lt;/select&gt;</span><span class="sc0">
You selected: {{selectedCar}}
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.cars</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        </span><span class="sc46">car01</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Ford"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc43">// key :value pairs</span><span class="sc41">
        </span><span class="sc46">car02</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Fiat"</span><span class="sc50">,</span><span class="sc41">
        </span><span class="sc46">car03</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Volvo"</span><span class="sc41">
    </span><span class="sc50">}</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
  
The selected value will always be the value in a key-value pair.
The value in a key-value pair can also be an object:
</span><span class="sc1">&lt;select</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"selectedCar"</span><span class="sc8"> </span><span class="sc4">ng-options</span><span class="sc8">=</span><span class="sc6">"x for (x, y) in cars"</span><span class="sc1">&gt;</span><span class="sc0"> </span><span class="sc1">&lt;/select&gt;</span><span class="sc0">
You selected: {{selectedCar.brand}}
Model: {{selectedCar.model}}
Color: {{selectedCar.color}}
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.cars</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        </span><span class="sc46">car01</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc46">brand</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Ford"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">model</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Mustang"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">color</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"red"</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc46">car02</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc46">brand</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Fiat"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">model</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"500"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">color</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"white"</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc46">car03</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc46">brand</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Volvo"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">model</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"XC90"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">color</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"black"</span><span class="sc50">}</span><span class="sc41">
    </span><span class="sc50">}</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41">
</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

The options in the dropdown list does not have to be the key in a key-value pair, it can also be the value, or a property of the value object:
</span><span class="sc1">&lt;select</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"selectedCar"</span><span class="sc8"> </span><span class="sc4">ng-options</span><span class="sc8">=</span><span class="sc6">"y.brand for (x, y) in cars"</span><span class="sc1">&gt;&lt;/select&gt;</span><span class="sc0">
You selected: {{selectedCar.brand}}
Model: {{selectedCar.model}}
Color: {{selectedCar.color}}
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.cars</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        </span><span class="sc46">car01</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc46">brand</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Ford"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">model</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Mustang"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">color</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"red"</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc46">car02</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc46">brand</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Fiat"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">model</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"500"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">color</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"white"</span><span class="sc50">},</span><span class="sc41">
        </span><span class="sc46">car03</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc46">brand</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"Volvo"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">model</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"XC90"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">color</span><span class="sc41"> </span><span class="sc50">:</span><span class="sc41"> </span><span class="sc48">"black"</span><span class="sc50">}</span><span class="sc41">
    </span><span class="sc50">}</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
    
</span><span class="sc9">&lt;!----------------------------------------------------- SQL -----------------------------------------------------&gt;</span><span class="sc0">
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"customersCtrl"</span><span class="sc1">&gt;</span><span class="sc0">
 </span><span class="sc1">&lt;table&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;tr</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in names"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;td&gt;</span><span class="sc0">{{ x.Name }}</span><span class="sc1">&lt;/td&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;td&gt;</span><span class="sc0">{{ x.Country }}</span><span class="sc1">&lt;/td&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/tr&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/table&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
 
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'customersCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">,</span><span class="sc41"> $</span><span class="sc46">http</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
   $</span><span class="sc46">http.get</span><span class="sc50">(</span><span class="sc48">"http://www.w3schools.com/angular/customers_mysql.php"</span><span class="sc50">)</span><span class="sc41">
   </span><span class="sc50">.</span><span class="sc46">then</span><span class="sc50">(</span><span class="sc47">function</span><span class="sc41"> </span><span class="sc50">(</span><span class="sc46">response</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">$</span><span class="sc46">scope.names</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">response.data.records</span><span class="sc50">;});</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">
 
Server Code ASP.NET, Razor C# and SQL Lite
@{
Response.AppendHeader("Access-Control-Allow-Origin", "*")
Response.AppendHeader("Content-type", "application/json")
var db = Database.Open("Northwind");
var query = db.Query("SELECT CompanyName, City, Country FROM Customers");
var outp =""
var c = chr(34)
}
@foreach(var row in query)
{
if outp </span><span class="sc2">&lt;&gt;</span><span class="sc0"> "" then outp = outp + ","
outp = outp + "{" + c + "Name"    + c + ":" + c + @row.CompanyName + c + ","
outp = outp +       c + "City"    + c + ":" + c + @row.City        + c + ","
outp = outp +       c + "Country" + c + ":" + c + @row.Country     + c + "}"
}
outp ="{" + c + "records" + c + ":[" + outp + "]}"
@outp

</span><span class="sc9">&lt;!----------------------------------------------------- DOM -----------------------------------------------------&gt;</span><span class="sc0">
The ng-disabled directive binds AngularJS application data to the disabled attribute of HTML elements.
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"mySwitch=true"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;button</span><span class="sc8"> </span><span class="sc4">ng-disabled</span><span class="sc8">=</span><span class="sc6">"mySwitch"</span><span class="sc1">&gt;</span><span class="sc0">Click Me!</span><span class="sc1">&lt;/button&gt;</span><span class="sc0">
</span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"checkbox"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"mySwitch"</span><span class="sc11">/&gt;</span><span class="sc0">Button
{{ mySwitch }}

</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc8"> </span><span class="sc4">ng-init</span><span class="sc8">=</span><span class="sc6">"hour=13"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;p</span><span class="sc8"> </span><span class="sc4">ng-show</span><span class="sc8">=</span><span class="sc6">"hour &gt; 12"</span><span class="sc1">&gt;</span><span class="sc0">I am visible.</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0"> 

</span><span class="sc9">&lt;!----------------------------------------------------- EVENTS -----------------------------------------------------&gt;</span><span class="sc0">
You can add AngularJS event listeners to your HTML elements by using one or more of these directives:
ng-blur, ng-change, ng-click, ng-copy, ng-cut, ng-dblclick, ng-focus, ng-keydown, ng-keypress, ng-keyup, ng-mousedown, ng-mouseenter, ng-mouseleave, ng-mousemove, ng-mouseover, ng-mouseup, ng-paste

</span><span class="sc1">&lt;h1</span><span class="sc8"> </span><span class="sc4">ng-mousemove</span><span class="sc8">=</span><span class="sc6">"count = count + 1"</span><span class="sc1">&gt;</span><span class="sc0">Mouse Over Me!</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
</span><span class="sc1">&lt;h2&gt;</span><span class="sc0">{{ count }}</span><span class="sc1">&lt;/h2&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.count</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc45">0</span><span class="sc50">;</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc1">&lt;/script&gt;</span><span class="sc0"> 

You can also refer to a function:
</span><span class="sc1">&lt;button</span><span class="sc8"> </span><span class="sc4">ng-click</span><span class="sc8">=</span><span class="sc6">"myFunction()"</span><span class="sc1">&gt;</span><span class="sc0">Click Me!</span><span class="sc1">&lt;/button&gt;</span><span class="sc0">
{{ count }}
</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.count</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc45">0</span><span class="sc50">;</span><span class="sc41">
    $</span><span class="sc46">scope.myFunction</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        $</span><span class="sc46">scope.count</span><span class="sc50">++;</span><span class="sc41">
    </span><span class="sc50">}</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0"> 

Toggle, True/False
If you want to show a section of HTML code when a button is clicked, and hide when the button is clicked again, like a dropdown menu, make the button behave like a toggle switch:
</span><span class="sc1">&lt;button</span><span class="sc8"> </span><span class="sc4">ng-click</span><span class="sc8">=</span><span class="sc6">"myFunc()"</span><span class="sc1">&gt;</span><span class="sc0">Click Me!</span><span class="sc1">&lt;/button&gt;</span><span class="sc0">
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-show</span><span class="sc8">=</span><span class="sc6">"showMe"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;h1&gt;</span><span class="sc0">Menu:</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;div&gt;</span><span class="sc0">Pizza</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;div&gt;</span><span class="sc0">Pasta</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;div&gt;</span><span class="sc0">Pesce</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc41">        </span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
                </span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                    $</span><span class="sc46">scope.showMe</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">false</span><span class="sc50">;</span><span class="sc41">
                    $</span><span class="sc46">scope.myFunc</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                        $</span><span class="sc46">scope.showMe</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc50">!</span><span class="sc41">$</span><span class="sc46">scope.showMe</span><span class="sc50">;</span><span class="sc41">
                    </span><span class="sc50">}</span><span class="sc41">
                </span><span class="sc50">});</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

You can pass the $event object as an argument when calling the function.
The $event object contains the browser's event object:
</span><span class="sc1">&lt;h1</span><span class="sc8"> </span><span class="sc4">ng-mousemove</span><span class="sc8">=</span><span class="sc6">"myFunc($event)"</span><span class="sc1">&gt;</span><span class="sc0">Mouse Over Me!</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
Coordinates: {{x + ', ' + y}}
</span><span class="sc1">&lt;script&gt;</span><span class="sc41">        </span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
                </span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'myCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                    $</span><span class="sc46">scope.myFunc</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc46">myE</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                        $</span><span class="sc46">scope.x</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">myE.clientX</span><span class="sc50">;</span><span class="sc41">
                        $</span><span class="sc46">scope.y</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">myE.clientY</span><span class="sc50">;</span><span class="sc41">
                    </span><span class="sc50">}</span><span class="sc41">
                </span><span class="sc50">});</span><span class="sc1">&lt;/script&gt;</span><span class="sc0"> 
                
</span><span class="sc9">&lt;!----------------------------------------------------- FORMS -----------------------------------------------------&gt;</span><span class="sc0">
Forms in AngularJS provides data-binding and validation of input controls.
Input controls are the HTML input elements: input elements, select elements, button elements, textarea elements
Input controls provides data-binding by using the ng-model directive.

A checkbox has the value true or false. Apply the ng-model directive to a checkbox, and use it's value in your application.
</span><span class="sc1">&lt;form&gt;</span><span class="sc0"> </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"checkbox"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myVar"</span><span class="sc1">&gt;</span><span class="sc0"> </span><span class="sc1">&lt;/form&gt;</span><span class="sc0">

Display some text, based on the value of the selected radio button:
</span><span class="sc1">&lt;form&gt;</span><span class="sc0">
  Pick a topic:
  </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"radio"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myVar"</span><span class="sc8"> </span><span class="sc3">value</span><span class="sc8">=</span><span class="sc6">"dogs"</span><span class="sc1">&gt;</span><span class="sc0">Dogs
  </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"radio"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myVar"</span><span class="sc8"> </span><span class="sc3">value</span><span class="sc8">=</span><span class="sc6">"tuts"</span><span class="sc1">&gt;</span><span class="sc0">Tutorials
  </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"radio"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myVar"</span><span class="sc8"> </span><span class="sc3">value</span><span class="sc8">=</span><span class="sc6">"cars"</span><span class="sc1">&gt;</span><span class="sc0">Cars
</span><span class="sc1">&lt;/form&gt;</span><span class="sc0">
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-switch</span><span class="sc8">=</span><span class="sc6">"myVar"</span><span class="sc1">&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-switch-when</span><span class="sc8">=</span><span class="sc6">"dogs"</span><span class="sc1">&gt;</span><span class="sc0">
     </span><span class="sc1">&lt;h1&gt;</span><span class="sc0">Dogs</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
     </span><span class="sc1">&lt;p&gt;</span><span class="sc0">Welcome to a world of dogs.</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-switch-when</span><span class="sc8">=</span><span class="sc6">"tuts"</span><span class="sc1">&gt;</span><span class="sc0">
     </span><span class="sc1">&lt;h1&gt;</span><span class="sc0">Tutorials</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
     </span><span class="sc1">&lt;p&gt;</span><span class="sc0">Learn from examples.</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-switch-when</span><span class="sc8">=</span><span class="sc6">"cars"</span><span class="sc1">&gt;</span><span class="sc0">
     </span><span class="sc1">&lt;h1&gt;</span><span class="sc0">Cars</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
     </span><span class="sc1">&lt;p&gt;</span><span class="sc0">Read about cars.</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">

Display some text, based on the value of the selected option:
</span><span class="sc1">&lt;form&gt;</span><span class="sc0">
  Select a topic:
  </span><span class="sc1">&lt;select</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myVar"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;option</span><span class="sc8"> </span><span class="sc3">value</span><span class="sc8">=</span><span class="sc6">""</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;option</span><span class="sc8"> </span><span class="sc3">value</span><span class="sc8">=</span><span class="sc6">"dogs"</span><span class="sc1">&gt;</span><span class="sc0">Dogs
    </span><span class="sc1">&lt;option</span><span class="sc8"> </span><span class="sc3">value</span><span class="sc8">=</span><span class="sc6">"tuts"</span><span class="sc1">&gt;</span><span class="sc0">Tutorials
    </span><span class="sc1">&lt;option</span><span class="sc8"> </span><span class="sc3">value</span><span class="sc8">=</span><span class="sc6">"cars"</span><span class="sc1">&gt;</span><span class="sc0">Cars
  </span><span class="sc1">&lt;/select&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/form&gt;</span><span class="sc0">
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-switch</span><span class="sc8">=</span><span class="sc6">"myVar"</span><span class="sc1">&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-switch-when</span><span class="sc8">=</span><span class="sc6">"dogs"</span><span class="sc1">&gt;</span><span class="sc0">
     </span><span class="sc1">&lt;h1&gt;</span><span class="sc0">Dogs</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
     </span><span class="sc1">&lt;p&gt;</span><span class="sc0">Welcome to a world of dogs.</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-switch-when</span><span class="sc8">=</span><span class="sc6">"tuts"</span><span class="sc1">&gt;</span><span class="sc0">
     </span><span class="sc1">&lt;h1&gt;</span><span class="sc0">Tutorials</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
     </span><span class="sc1">&lt;p&gt;</span><span class="sc0">Learn from examples.</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-switch-when</span><span class="sc8">=</span><span class="sc6">"cars"</span><span class="sc1">&gt;</span><span class="sc0">
     </span><span class="sc1">&lt;h1&gt;</span><span class="sc0">Cars</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
     </span><span class="sc1">&lt;p&gt;</span><span class="sc0">Read about cars.</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">

</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myApp"</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"formCtrl"</span><span class="sc1">&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;form</span><span class="sc8"> </span><span class="sc4">novalidate</span><span class="sc1">&gt;</span><span class="sc0">
    First Name:</span><span class="sc1">&lt;br&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"text"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"user.firstName"</span><span class="sc1">&gt;&lt;br&gt;</span><span class="sc0">
    Last Name:</span><span class="sc1">&lt;br&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"text"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"user.lastName"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;br&gt;&lt;br&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;button</span><span class="sc8"> </span><span class="sc4">ng-click</span><span class="sc8">=</span><span class="sc6">"reset()"</span><span class="sc1">&gt;</span><span class="sc0">RESET</span><span class="sc1">&lt;/button&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/form&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;p&gt;</span><span class="sc0">form = {{user }}</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;p&gt;</span><span class="sc0">master = {{master}}</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc41">        </span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
                </span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc49">'formCtrl'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                    $</span><span class="sc46">scope.master</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc46">firstName</span><span class="sc50">:</span><span class="sc48">"John"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">lastName</span><span class="sc50">:</span><span class="sc48">"Doe"</span><span class="sc50">};</span><span class="sc41">
                    $</span><span class="sc46">scope.reset</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                        $</span><span class="sc46">scope.user</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.copy</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope.master</span><span class="sc50">);</span><span class="sc41">
                    </span><span class="sc50">};</span><span class="sc41">
                    $</span><span class="sc46">scope.reset</span><span class="sc50">();</span><span class="sc41">
                </span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

The ng-app directive defines the AngularJS application.
The ng-controller directive defines the application controller.
The ng-model directive binds two input elements to the user object in the model.
The formCtrl controller sets initial values to the master object, and defines the reset() method.
The reset() method sets the user object equal to the master object.
The ng-click directive invokes the reset() method, only if the button is clicked.
The novalidate attribute is not needed for this application, but normally you will use it in AngularJS forms, to override standard HTML5 validation.

</span><span class="sc9">&lt;!----------------------------------------------------- VALIDATION -----------------------------------------------------&gt;</span><span class="sc0">

</span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"submit"</span><span class="sc8"> </span><span class="sc4">ng-disabled</span><span class="sc8">=</span><span class="sc6">"myForm.user.$dirty &amp;&amp; myForm.user.$invalid || myForm.email.$dirty &amp;&amp; myForm.email.$invalid"</span><span class="sc1">&gt;</span><span class="sc0">

</span><span class="sc1">&lt;form</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myForm"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myInput"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myInput"</span><span class="sc8"> </span><span class="sc4">required</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myEmail"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myEmail"</span><span class="sc8"> </span><span class="sc3">type</span><span class="sc8">=</span><span class="sc6">"email"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/form&gt;</span><span class="sc0">
</span><span class="sc1">&lt;h1&gt;</span><span class="sc0">{{myForm.myInput.$valid}}</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">

Show an error message if the field has been touched AND is empty:
</span><span class="sc1">&lt;form</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myForm"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;p&gt;</span><span class="sc0">Name:    
        </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myName"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myName"</span><span class="sc8"> </span><span class="sc4">required</span><span class="sc1">&gt;</span><span class="sc0">
        </span><span class="sc1">&lt;span</span><span class="sc8"> </span><span class="sc4">ng-show</span><span class="sc8">=</span><span class="sc6">"myForm.myName.$touched &amp;&amp; myForm.myName.$invalid"</span><span class="sc1">&gt;</span><span class="sc0">The name is required.</span><span class="sc1">&lt;/span&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;p&gt;</span><span class="sc0">Adress:
        </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myAddress"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myAddress"</span><span class="sc8"> </span><span class="sc4">required</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/form&gt;</span><span class="sc0">

AngularJS adds CSS classes to forms and input fields depending on their states.
The following classes are added to, or removed from, input fields:
ng-untouched The field has not been touched yet
ng-touched The field has been touched
ng-pristine The field has not been  modified yet
ng-dirty The field has been modified
ng-valid The field content is valid
ng-invalid The field content is not valid
ng-valid-key One key for each validation. Example: ng-valid-required, useful when there are more than one thing that must be validated
ng-invalid-key Example: ng-invalid-required

The following classes are added to, or removed from, forms:
ng-pristine No fields has not been modified yet
ng-dirty One or more fields has been modified
ng-valid The form content is valid
ng-invalid The form content is not valid
ng-valid-key One key for each validation. Example: ng-valid-required, useful when there are more than one thing that must be validated
ng-invalid-key Example: ng-invalid-required

The classes are removed if the value they represent is false.
Add styles for these classes to give your application a better and more intuitive user interface.

Apply styles, using standard CSS:
</span><span class="sc1">&lt;style&gt;</span><span class="sc0">
input.ng-invalid {
    background-color: pink;
}
input.ng-valid {
    background-color: lightgreen;
}
</span><span class="sc1">&lt;/style&gt;</span><span class="sc0">

Custom Validation
To create your own validation function is a bit more tricky. You have to add a new directive to your application, and deal with the validation inside a function with certain specified arguments.

Create your own directive, containing a custom validation function, and refer to it by using my-directive.
The field will only be valid if the value contains the character "e"
</span><span class="sc1">&lt;form</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myForm"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">name</span><span class="sc8">=</span><span class="sc6">"myInput"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"myInput"</span><span class="sc8"> </span><span class="sc4">required</span><span class="sc8"> </span><span class="sc4">my-directive</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/form&gt;</span><span class="sc0">
</span><span class="sc1">&lt;p&gt;</span><span class="sc0">The input's valid state is:</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
</span><span class="sc1">&lt;h1&gt;</span><span class="sc0">{{myForm.myInput.$valid}}</span><span class="sc1">&lt;/h1&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc41">        </span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41">
                </span><span class="sc46">app.directive</span><span class="sc50">(</span><span class="sc49">'myDirective'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                    </span><span class="sc47">return</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                        </span><span class="sc46">require</span><span class="sc50">:</span><span class="sc41"> </span><span class="sc49">'ngModel'</span><span class="sc50">,</span><span class="sc41">
                        </span><span class="sc46">link</span><span class="sc50">:</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc46">scope</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">element</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">attr</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc46">mCtrl</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                              </span><span class="sc47">function</span><span class="sc41"> </span><span class="sc46">myValidation</span><span class="sc50">(</span><span class="sc47">value</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                                </span><span class="sc47">if</span><span class="sc41"> </span><span class="sc50">(</span><span class="sc46">value.indexOf</span><span class="sc50">(</span><span class="sc48">"e"</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">&gt;</span><span class="sc41"> </span><span class="sc50">-</span><span class="sc45">1</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                                    </span><span class="sc46">mCtrl.</span><span class="sc41">$</span><span class="sc46">setValidity</span><span class="sc50">(</span><span class="sc49">'charE'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">true</span><span class="sc50">);</span><span class="sc41">
                                </span><span class="sc50">}</span><span class="sc41"> </span><span class="sc47">else</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                                    </span><span class="sc46">mCtrl.</span><span class="sc41">$</span><span class="sc46">setValidity</span><span class="sc50">(</span><span class="sc49">'charE'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">false</span><span class="sc50">);</span><span class="sc41">
                                </span><span class="sc50">}</span><span class="sc41">
                                </span><span class="sc47">return</span><span class="sc41"> </span><span class="sc47">value</span><span class="sc50">;</span><span class="sc41">
                            </span><span class="sc50">}</span><span class="sc41">
                            </span><span class="sc46">mCtrl.</span><span class="sc41">$</span><span class="sc46">parsers.push</span><span class="sc50">(</span><span class="sc46">myValidation</span><span class="sc50">);</span><span class="sc41">
                        </span><span class="sc50">}</span><span class="sc41">
                    </span><span class="sc50">};</span><span class="sc41">
                </span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

</span><span class="sc9">&lt;!----------------------------------------------------- API -----------------------------------------------------&gt;</span><span class="sc0">
angular.lowercase(), angular.uppercase(), angular.isString(), angular.isNumber()
$scope.x1 = "JOHN";
$scope.x2 = angular.lowercase($scope.x1);

</span><span class="sc9">&lt;!----------------------------------------------------- W3 CSS -----------------------------------------------------&gt;</span><span class="sc0">
</span><span class="sc1">&lt;link</span><span class="sc8"> </span><span class="sc3">rel</span><span class="sc8">=</span><span class="sc6">"stylesheet"</span><span class="sc8"> </span><span class="sc3">href</span><span class="sc8">=</span><span class="sc6">"http://www.w3schools.com/lib/w3.css"</span><span class="sc1">&gt;</span><span class="sc0">

</span><span class="sc9">&lt;!----------------------------------------------------- INCLUDES -----------------------------------------------------&gt;</span><span class="sc0">

</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-include</span><span class="sc8">=</span><span class="sc6">"'myFile.htm'"</span><span class="sc1">&gt;&lt;/div&gt;</span><span class="sc0">

By default, the ng-include directive does not allow you to include files from other domains.
To include files from another domain, you can add a whitelist of legal files and/or domains in the config function of your application:
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-include</span><span class="sc8">=</span><span class="sc6">"'http://www.refsnesdata.no/angular_include.asp'"</span><span class="sc1">&gt;&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script&gt;</span><span class="sc41">            </span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc49">'myApp'</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[])</span><span class="sc41">
                    </span><span class="sc46">app.config</span><span class="sc50">(</span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">sceDelegateProvider</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
                        $</span><span class="sc46">sceDelegateProvider.resourceUrlWhitelist</span><span class="sc50">([</span><span class="sc41">
                            </span><span class="sc49">'http://www.refsnesdata.no/**'</span><span class="sc41">
                        </span><span class="sc50">]);</span><span class="sc41">
                    </span><span class="sc50">});</span><span class="sc41"> </span><span class="sc1">&lt;/script&gt;</span><span class="sc0">

</span><span class="sc9">&lt;!----------------------------------------------------- APPLICATION -----------------------------------------------------&gt;</span><span class="sc0">

</span><span class="sc21">&lt;!</span><span class="sc26">DOCTYPE html</span><span class="sc21">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;html&gt;</span><span class="sc0">
</span><span class="sc1">&lt;script</span><span class="sc8"> </span><span class="sc3">src</span><span class="sc8">=</span><span class="sc6">"http://ajax.googleapis.com/ajax/libs/angularjs/1.4.8/angular.min.js"</span><span class="sc1">&gt;&lt;/script&gt;</span><span class="sc0">
</span><span class="sc1">&lt;link</span><span class="sc8"> </span><span class="sc3">rel</span><span class="sc8">=</span><span class="sc6">"stylesheet"</span><span class="sc8"> </span><span class="sc3">href</span><span class="sc8">=</span><span class="sc6">"http://www.w3schools.com/lib/w3.css"</span><span class="sc1">&gt;</span><span class="sc0">
</span><span class="sc1">&lt;body&gt;</span><span class="sc0">
</span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc4">ng-app</span><span class="sc8">=</span><span class="sc6">"myShoppingList"</span><span class="sc8"> </span><span class="sc4">ng-cloak</span><span class="sc8"> </span><span class="sc4">ng-controller</span><span class="sc8">=</span><span class="sc6">"myCtrl"</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-card-2 w3-margin"</span><span class="sc8"> </span><span class="sc3">style</span><span class="sc8">=</span><span class="sc6">"max-width:400px;"</span><span class="sc1">&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;header</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-container w3-light-grey w3-padding-hor-16"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;h3&gt;</span><span class="sc0">My Shopping List</span><span class="sc1">&lt;/h3&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/header&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;ul</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-ul"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;li</span><span class="sc8"> </span><span class="sc4">ng-repeat</span><span class="sc8">=</span><span class="sc6">"x in products"</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-padding-hor-16"</span><span class="sc1">&gt;</span><span class="sc0">{{x}}</span><span class="sc1">&lt;span</span><span class="sc8"> </span><span class="sc4">ng-click</span><span class="sc8">=</span><span class="sc6">"removeItem($index)"</span><span class="sc8"> </span><span class="sc3">style</span><span class="sc8">=</span><span class="sc6">"cursor:pointer;"</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-right w3-margin-right"</span><span class="sc1">&gt;</span><span class="sc0">×</span><span class="sc1">&lt;/span&gt;&lt;/li&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/ul&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-container w3-light-grey w3-padding-hor-16"</span><span class="sc1">&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-row w3-margin-top"</span><span class="sc1">&gt;</span><span class="sc0">
      </span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-col s10"</span><span class="sc1">&gt;</span><span class="sc0">
        </span><span class="sc1">&lt;input</span><span class="sc8"> </span><span class="sc3">placeholder</span><span class="sc8">=</span><span class="sc6">"Add shopping items here"</span><span class="sc8"> </span><span class="sc4">ng-model</span><span class="sc8">=</span><span class="sc6">"addMe"</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-input w3-border w3-padding"</span><span class="sc1">&gt;</span><span class="sc0">
      </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
      </span><span class="sc1">&lt;div</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-col s2"</span><span class="sc1">&gt;</span><span class="sc0">
        </span><span class="sc1">&lt;button</span><span class="sc8"> </span><span class="sc4">ng-click</span><span class="sc8">=</span><span class="sc6">"addItem()"</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-btn w3-padding w3-green"</span><span class="sc1">&gt;</span><span class="sc0">Add</span><span class="sc1">&lt;/button&gt;</span><span class="sc0">
      </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
    </span><span class="sc1">&lt;p</span><span class="sc8"> </span><span class="sc3">class</span><span class="sc8">=</span><span class="sc6">"w3-padding-left w3-text-red"</span><span class="sc1">&gt;</span><span class="sc0">{{errortext}}</span><span class="sc1">&lt;/p&gt;</span><span class="sc0">
  </span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/div&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/body&gt;</span><span class="sc0">
</span><span class="sc1">&lt;/html&gt;</span><span class="sc0">

</span><span class="sc1">&lt;script&gt;</span><span class="sc40">
</span><span class="sc47">var</span><span class="sc41"> </span><span class="sc46">app</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc46">angular.module</span><span class="sc50">(</span><span class="sc48">"myShoppingList"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc50">[]);</span><span class="sc41"> 
</span><span class="sc46">app.controller</span><span class="sc50">(</span><span class="sc48">"myCtrl"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
    $</span><span class="sc46">scope.products</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc50">[</span><span class="sc48">"Milk"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc48">"Bread"</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc48">"Cheese"</span><span class="sc50">];</span><span class="sc41">
    $</span><span class="sc46">scope.addItem</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc41"> </span><span class="sc50">()</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        $</span><span class="sc46">scope.errortext</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">""</span><span class="sc50">;</span><span class="sc41">
        </span><span class="sc47">if</span><span class="sc41"> </span><span class="sc50">(!</span><span class="sc41">$</span><span class="sc46">scope.addMe</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc47">return</span><span class="sc50">;}</span><span class="sc41">
        </span><span class="sc47">if</span><span class="sc41"> </span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope.products.indexOf</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope.addMe</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">==</span><span class="sc41"> </span><span class="sc50">-</span><span class="sc45">1</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
            $</span><span class="sc46">scope.products.push</span><span class="sc50">(</span><span class="sc41">$</span><span class="sc46">scope.addMe</span><span class="sc50">);</span><span class="sc41">
        </span><span class="sc50">}</span><span class="sc41"> </span><span class="sc47">else</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
            $</span><span class="sc46">scope.errortext</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">"The item is already in your shopping list."</span><span class="sc50">;</span><span class="sc41">
        </span><span class="sc50">}</span><span class="sc41">
    </span><span class="sc50">}</span><span class="sc41">
    $</span><span class="sc46">scope.removeItem</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc47">function</span><span class="sc41"> </span><span class="sc50">(</span><span class="sc46">x</span><span class="sc50">)</span><span class="sc41"> </span><span class="sc50">{</span><span class="sc41">
        $</span><span class="sc46">scope.errortext</span><span class="sc41"> </span><span class="sc50">=</span><span class="sc41"> </span><span class="sc48">""</span><span class="sc50">;</span><span class="sc41">    
        $</span><span class="sc46">scope.products.splice</span><span class="sc50">(</span><span class="sc46">x</span><span class="sc50">,</span><span class="sc41"> </span><span class="sc45">1</span><span class="sc50">);</span><span class="sc41">
    </span><span class="sc50">}</span><span class="sc41">
</span><span class="sc50">});</span><span class="sc41">
</span><span class="sc1">&lt;/script&gt;</span><span class="sc0">




</span></div></body>
</html>
