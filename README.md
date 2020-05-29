# WPF AutoComplete TextBox

![logo](https://github.com/quicoli/WPF-AutoComplete-TextBox/blob/develop/AutoCompleteTextBox/Logo/AutoCompleteTextBox.png?raw=true=32px)


Install:
```PM> Install-Package AutoCompleteTextBox -Version 1.1.0```


>WPF AutoComplete TextBox is an original work from [Bhardwaj Deepak](http://www.codeproject.com/Tips/801004/WPF-AutoComplete-TextBox)

This control originally features:

* Load suggestions on-demand
* Supports MVVM
* Asynchronously load suggestions
* Watermark
* Icon
* DataTemplate for suggestions
* DataTemplateSelector for suggestions

### Changes/improvements

1. I've included two more properties for making things easier:
  * MaxLength
  * CharacterCasing
2. Also, I fixed up the focus control.
3. Removed VB.NET stuff from original solution.
4. Added a new demo showcasing the new capabilities
5. Added a custom style in the new demo, turning on validation messages  
6. Added property MaxPopupHeight. Setting this property, will limit the popup height to the size you wish.
7. Much more from collaborators!

### The Demo WpfControls.Demo

It's a simple WPF application using the [Material Design in XAML Toolkit](http://materialdesigninxaml.net/) and MVVM showing how to search for the American States while typing.  See it in action!

![demo in action](http://g.recordit.co/xhSXhMkSRP.gif "Demo in Action")


PS.: Screen cast by: http://recordit.co/ 

@scor4er

### My changes/improvements

I need this control to support multiple items in a text box separated with some character. The logic will stay the same but when you select the item from the list it won't replace the whole text in a textbox but only the last item (item after specified item separator, comma for example).

Here's how it looks right now:

![demo in action](https://i.ibb.co/grHYccf/multi-items-demo.gif "Multiple selection") 

