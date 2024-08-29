<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128615488/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T223550)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms MVVM - Cascading Lookup Editors

A lookup editor can filter items in its dropdown based on a value in another lookup. This example utilizes the Model-View-ViewModel design pattern to implement cascading `LookUpEdit` controls. The example binds a child `LookUpEdit` data source to a collection in a view model that returns a list of business objects depending on a selected object in the master lookup.

Read the following KB article for additional information: [MVVM - How to implement cascading LookUpEdits](https://supportcenter.devexpress.com/ticket/details/t223617/mvvm-how-to-implement-cascading-lookupedits).


## Files to Review

* [MainForm.cs](./CS/T223550/MainForm.cs)
* [Customer.cs](./CS/T223550/Models/Customer.cs)
* [DataSourceHelper.cs](./CS/T223550/Models/DataSourceHelper.cs)
* [Order.cs](./CS/T223550/Models/Order.cs)
* [OrdersViewModel.cs](./CS/T223550/ViewModels/OrdersViewModel.cs)


## Documentation

* [Cascading Lookups](https://docs.devexpress.com/WindowsForms/116018/controls-and-libraries/editors-and-simple-controls/lookup-editors/cascading-lookups)
* [WinForms MVVM](https://docs.devexpress.com/WindowsForms/113955/build-an-application/winforms-mvvm)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-mvvm-cascading-lookups&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-mvvm-cascading-lookups&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
