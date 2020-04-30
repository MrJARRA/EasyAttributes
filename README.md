# EasyAttributes
EasyAttributes is an extension for the Unity Inspector , I made it from mixing [NaughtyAttributes](https://github.com/dbrizov/NaughtyAttributes) and [MyBox](https://github.com/Deadcows/MyBox)  and making some changess .

It expands the range of attributes that Unity provides so that you can create powerful inspectors without the need of 
custom editors or property drawers. It also provides attributes that can be applied to non-serialized fields or functions.

Most of the attributes are implemented using Unity's `CustomPropertyDrawer`, so they will work in your custom editors.
If you want all of the attributes to work in your custom editors, however, you must inherit from `NaughtyInspector` and use
the `NaughtyEditorGUI.PropertyField_Layout` function instead of `EditorGUILayout.PropertyField`.

## System Requirements
Unity 2018.3.0 or later versions. Feel free to try older version. Don't forget to include the EasyAttributes namespace.

## Installation
1. The package is available on the [openupm](https://openupm.com/) registry. You can install it via [openupm-cli](https://github.com/openupm/openupm-cli).

`openupm add com.dbrizov.naughtyattributes`.

2. You can also install via git url by adding this entry in your **manifest.json**.

`"com.dbrizov.naughtyattributes": "https://github.com/dbrizov/NaughtyAttributes.git#upm"`

## Support
If you would like to support me
* [My Patreon](https://www.patreon.com/FlyoFun)
* [Buy Me A Coffee](https://www.buymeacoffee.com/xjQoRlt)


## Button

A method can be marked as a button. A button appears in the inspector and executes the method if clicked. Works both with instance and static methods.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
	[Button]
	private void Method1() { }

	[Button("Button Text 1")]
	private void Method2() { }

	[Button(EColor.Blue)]
	private void Method3() { }

	[Button("Button Text 4" , EColor.Red)]
	private void Method4() { }
}
```

## BoxGroup
Surrounds grouped fields with a box.
```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
	[BoxGroup("Group 1")]
	public int firstInt;
	[BoxGroup("Group 1")]
	public int secondInt;

	[BoxGroup("Group 2" , EColor.Blue)]
	public float firstFloat;
	[BoxGroup("Group 2")]
	public float secondFloat;

	[BoxGroup("Group 3", EColor.Orange)]
	[MinMaxSlider(0.0f, 100.0f)]
	public Vector2 minMaxSlider;
	[BoxGroup("Group 3")]
	[Tag]
	public string myTag;
}
```
## Tag & Layer & Sprite Layer
Get  tag or layer or sprite layer

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
	[Tag]
	public string myTag;

	[Layer]
	public int myLayer;

	[SpriteLayer]
	public int mySpriteLayer;
}
```

## DefinedValues

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
	[DefinedValues(1, 2, 3)]
	public int myInt;

	[DefinedValues("name 1", "name 2", "name 3")]
	public string myString;

	[DefinedValues(1.45, 2.25, 3)]
	public float myFloat;
}
```

