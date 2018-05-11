# Brief Developer Docs

This document is intended to provide a general overview of the practices used in the ADbC program in order to aid in the development of future modules and features.

This document is not intended to teach HTML, Bootstrap, Javascript, C#, ASP.NET, Razor, LINQ, or any other language, framework, syntax, or tool. Please ensure that you are familiar with the foundations of any given element before modifying existing or implementing new content. 

---

## Structure

ADbC is built on ASP.NET MVC, which leverages the MVC (model-view-controller) architectural pattern as best it can. 
This methodology provides distinct forms of separation between independent functions within the application, and should be understood before developing additional materials. 
Each module grouping (Database Design, SQL, etc.) is given its own controller and set of views. Each module is then provided with its own view, and at points its independent model and any necessary partial views. 
In order to ease the development of the individual modules and reduce duplication, template views, reusable partials, and model inheritance are leveraged wherever possible. 

Database content is used to provide not only the module elements like questions and answers, but also used to construct things like menus (example in `Views` -> `Database Design` -> `MultipleChoiceQuestionBar`) in order to provide expandability and modification without altering the .cshtml elements of the site. 
For the example above, adding/removing question rows or modifying question text in the database is sufficient to alter the content provided to the users. 

Adding content to the models through additional partial class files can be useful for providing general-use methods and other attributes, especially in regards to models from which others inherit. 
This can be seen in `ModuleBaseModel.cs`, where the `GenerateBaseElements` method provides the object for the module itself, as well as the objects required to construct the Introduction and Usage modals. 

## Source control

ADbC has always lived on GitHub, and for good reason. 
Remote collaboration is a great tool for busy students, and really developers at large, and using source/version management tools like Git to manage concurrent development and availability of code is an industry standard. 
For student's working on this project at Saint Martin's, it's recommended that you use your individual GitHub accounts and add them as collaborators from the `smu-adbc` account. 
For any developers that may wish to work on this project independently, feel free to fork the repository and the students currently handling the project will (hopefully) maintain contact about any issues or PRs that come up. 

Currently, the version of ADbC that is currently active (available within Saint Martin's only: [adbc.stmartn.edu]) is from the `StMartinServer` branch of the repository, and has slight modifications related to the configuration available on-site. 

## Quirks

Due to the auto-generation of code that occurs when using the LINQ-to-SQL datacontexts (DCs)that ADbC's models are built on, the model inheritance between these requires special attention in order for it to function properly. 
Model inheritance is not an explicitly supported feature of these DCs, and so modifying the DC designer will cause the name of the parent class to be overwritten with the name of the default parent class, thereby causing build errors due to mismatched parent classes in the partial class files, as well as "missing" attributes that are present on the custom parent but not the defaul parent. 
To remedy this, modify the `{model name}.designer.cs` file and change the parent class name from the default to the custom parent. 

The module introductory modals are constructed from database rows defining sections and section content. Currently, these are collected as HTML that is inserted directly into the page being rendered. This is not the best implementation, but provided much a much simpler way to account for emphasized text, lists, and other formatting anomalies. Using RTF if possible, or even setting type codes for various elements of the modal content, would allow for similar results, but is a bigger time investment. This would be a great feature to take on as a relatively small-scale improvement on the current system.

---

## Author's notes

Althought we do our best, we are not (yet) experts in the techniques and tools used to build this new version of ADbC. We have done our best to implement the features using typical best practices to the best of our abilities, but as seen above, there are some interesting methods used to overcome certain limitations, be those of time, skill, or other resources. We apologize for any confusion, and support the improvement of these elements by future developers. Best of luck!

#### -*The JSAND Team*

