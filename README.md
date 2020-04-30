# EasyAttributes
EasyAttributes is an extension for the Unity Inspector , I made it from mixing [NaughtyAttributes](https://github.com/dbrizov/NaughtyAttributes) and [MyBox](https://github.com/Deadcows/MyBox)  and making some changess .

It expands the range of attributes that Unity provides so that you can create powerful inspectors without the need of 
custom editors or property drawers. It also provides attributes that can be applied to non-serialized fields or functions.

Most of the attributes are implemented using Unity's `CustomPropertyDrawer`, so they will work in your custom editors.
If you want all of the attributes to work in your custom editors, however, you must inherit from `NaughtyInspector` and use
the `NaughtyEditorGUI.PropertyField_Layout` function instead of `EditorGUILayout.PropertyField`.

## System Requirements
Unity 2018.3.0 or later versions. Feel free to try older version. Don't forget to include the NaughtyAttributes namespace.

## Installation
1. The package is available on the [openupm](https://openupm.com/) registry. You can install it via [openupm-cli](https://github.com/openupm/openupm-cli).

`openupm add com.dbrizov.naughtyattributes`.

2. You can also install via git url by adding this entry in your **manifest.json**.

`"com.dbrizov.naughtyattributes": "https://github.com/dbrizov/NaughtyAttributes.git#upm"`

## Support
If you would like to support me
* [My Patreon](https://www.patreon.com/FlyoFun)
* [Buy Me A Coffee](https://www.buymeacoffee.com/xjQoRlt)




```c#
public class NaughtyComponent : MonoBehaviour
{
	[Button]
	private void MethodOne() { }

	[Button("Button Text")]
	private void MethodTwo() { }
}
```




