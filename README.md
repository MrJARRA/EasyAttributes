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
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/Button.png)
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
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/BoxGroup.png)
## Tag & Layer & Sprite Layer
Select an  tag or layer or sprite layer via dropdown interface.

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
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/Tag-Layer-SpriteLayer.png)
## DefinedValues

Provides an interface for dropdown value selection( int , string ,float , vector ...).
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
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/DefinedValues.png)
## CurveRange
Set bounds and modify curve color for AnimationCurves

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
	[CurveRange(-1, -1, 1, 1)]
	public AnimationCurve curve;
	
	[CurveRange(EColor.Orange)]
	public AnimationCurve curve1;
	
	[CurveRange(0, 0, 5, 5, EColor.Red)]
	public AnimationCurve curve2;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/CurveRange.png)
## EnumFlags
Provides dropdown interface for setting enum flags.

```c#
using EasyAttributes;
public enum Direction
{
	None = 0,
	Right = 1 << 0,
	Left = 1 << 1,
	Up = 1 << 2,
	Down = 1 << 3
}
public class Easy : MonoBehaviour
{
	[EnumFlags]
	public Direction flags;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/EnumFlags.png)
## HorizontalLine

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
	[HorizontalLine(color: EColor.Red)]
	public int red;

	[HorizontalLine(color: EColor.Green)]
	public int green;

	[HorizontalLine(color: EColor.Blue)]
	public int blue;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/HorizontalLine.png)
## InfoBox
Used for providing additional information.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        [InfoBox("This is my int", EInfoBoxType.Normal)]
	public int myInt;

	[InfoBox("This is my float", EInfoBoxType.Warning)]
	public float myFloat;

	[InfoBox("This is my vector", EInfoBoxType.Error)]
	public Vector3 myVector;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/InfoBox.png)
## InputAxis
Select an input axis via dropdown interface.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
     [InputAxis]
	public string inputAxis;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/InputAxis.png)
## MinMaxSlider
A double slider. The min value is saved to the **X** property, and the **max value** is saved to the **Y** property of a **Vector2** field.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
     [MinMaxSlider(0.0f, 100.0f)]
     public Vector2 minMaxSlider;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/MinMaxSlider.png)
## ProgressBar

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        [ProgressBar("Health", 300, EColor.Red)]
	public int health = 250;

	[ProgressBar("Mana", 100, EColor.Blue)]
	public int mana = 25;

	[ProgressBar("Stamina", 200, EColor.Green)]
	public int stamina = 150;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/ProgressBar.png)
## ReorderableList
Provides array type fields with an interface for easy reordering of elements.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        [ReorderableList]
	public int[] intArray;

	[ReorderableList]
	public List<float> floatArray;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/ReorderableList_Inspector.gif)
## ReadOnly
Makes a field read only.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        [ReadOnly]
	public Vector3 forwardVector = Vector3.forward;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/ReadOnly.png)
## ResizableTextArea
A resizable text area where you can see the whole text. Unlike Unity's **Multiline** and **TextArea** attributes where you can see only 3 rows of a given text, and in order to see it or modify it you have to manually scroll down to the desired row.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        [ResizableTextArea]
	public string resizableTextArea;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/ResizableTextArea.png)
## Scene
Select a scene from the build settings via dropdown interface.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        [Scene]
	public string bootScene; // scene name

	[Scene]
	public int tutorialScene; // scene index
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/Scene.png)
## ShowAssetPreview
Shows the texture preview of a given asset (Sprite, Prefab...).

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        [ShowAssetPreview]
	public Sprite sprite;

	[ShowAssetPreview(128, 128)]
	public GameObject prefab;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/ShowAssetPreview.png)
## ShowNativeProperty
Shows native C# properties in the inspector. All native properties are displayed at the bottom of the inspector after the non-serialized fields and before the method buttons. It supports only certain types **(bool, int, long, float, double, string, Vector2, Vector3, Vector4, Color, Bounds, Rect, UnityEngine.Object)**.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        public List<Transform> transforms;

	[ShowNativeProperty]
	public int TransformsCount => transforms.Count;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/ShowNativeProperty.png)
## ShowNonSerializedField
Shows non-serialized fields in the inspector. All non-serialized fields are displayed at the bottom of the inspector before the method buttons. Keep in mind that if you change a non-static non-serialized field in the code - the value in the inspector will be updated after you press **Play** in the editor. There is no such issue with static non-serialized fields because their values are updated at compile time. It supports only certain types **(bool, int, long, float, double, string, Vector2, Vector3, Vector4, Color, Bounds, Rect, UnityEngine.Object)**.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        [ShowNonSerializedField]
	private int myInt = 10;

	[ShowNonSerializedField]
	private const float PI = 3.14159f;

	[ShowNonSerializedField]
	private static readonly Vector3 CONST_VECTOR = Vector3.one;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/ShowNonSerializedField.png)
## EnableIf / DisableIf
```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        public bool enableMyInt;

	[EnableIf("enableMyInt")]
	public int myInt;

	[EnableIf("Enabled")]
	public float myFloat;

	[EnableIf("NotEnabled")]
	public Vector3 myVector;

	public bool Enabled() { return true; }

	public bool NotEnabled => false;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/EnableIf_Inspector.gif)
You can have more than one condition.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        public bool flag0;
	public bool flag1;

	[EnableIf(EConditionOperator.And, "flag0", "flag1")]
	public int enabledIfAll;

	[EnableIf(EConditionOperator.Or, "flag0", "flag1")]
	public int enabledIfAny;
}
```
## ShowIf / HideIf
```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        public bool showInt;

	[ShowIf("showInt")]
	public int myInt;

	[ShowIf("AlwaysShow")]
	public float myFloat;

	[ShowIf("NeverShow")]
	public Vector3 myVector;

	public bool AlwaysShow() { return true; }

	public bool NeverShow => false;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/ShowIf_Inspector.gif)
You can have more than one condition.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        public bool flag0;
	public bool flag1;

	[ShowIf(EConditionOperator.And, "flag0", "flag1")]
	public int showIfAll;

	[ShowIf(EConditionOperator.Or, "flag0", "flag1")]
	public int showIfAny;
}
```
## ShortName
Override default field label.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        [ShortName("Short Name")]
	public string veryVeryLongName;

	[ShortName("RGB")]
	public Vector3 vectorXYZ;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/ShortName.png)
## OnValueChanged
Detects a value change and executes a callback. Keep in mind that the event is detected only when the value is changed from the inspector. If you want a runtime event, you should probably use an event/delegate and subscribe to it.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        [OnValueChanged("OnValueChangedCallback")]
	public int myInt;

	private void OnValueChangedCallback()
	{
		Debug.Log(myInt);
	}
}
```
## Required
Used to remind the developer that a given reference type field is required.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        [Required]
	public Transform myTransform;

	[Required("Custom required text")]
	public GameObject myGameObject;
}
```
![Image](https://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/Required.png)
## ValidateInput
The most powerful ValidatorAttribute.

```c#
using EasyAttributes;

public class Easy : MonoBehaviour
{
        [ValidateInput("IsNotNull")]
	public Transform myTransform;

	[ValidateInput("IsGreaterThanZero", "myInteger must be greater than zero")]
	public int myInt;

	private bool IsNotNull(Transform tr)
	{
		return tr != null;
	}

	private bool IsGreaterThanZero(int value)
	{
		return value > 0;
	}
}
```
![Image](hhttps://github.com/MrJARRA/EasyAttributes/blob/master/Documentation/ValidateInput.png)
