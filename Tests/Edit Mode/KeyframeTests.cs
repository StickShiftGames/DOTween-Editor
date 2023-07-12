using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;


using DG.Tweening;
using DG.Tweening.Editor;

public class KeyframeTests
{
public class ComponentCheck : KeyframeTests
{
    [Test]
    public void KeyframeTests_DOMove_Check()
    {
        // Setup
        GameObject testObject = Create3DTestObject();
        
        // Target
        DOT_DOMove testClass = new DOT_DOMove();
        bool result = testClass.CheckProperComponent(testObject);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void KeyframeTests_DORotate3D_Check()
    {
        // Setup
        GameObject testObject = Create3DTestObject();
        
        // Target
        DOT_DORotate_3D testClass = new DOT_DORotate_3D();
        bool result = testClass.CheckProperComponent(testObject);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void KeyframeTests_DOScale_Check()
    {
        // Setup
        GameObject testObject = Create3DTestObject();
        
        // Target
        DOT_DOScale testClass = new DOT_DOScale();
        bool result = testClass.CheckProperComponent(testObject);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void KeyframeTests_DOAnchorPos_Check()
    {
        // Setup
        GameObject testObject = Create2DTestObject();
        
        // Target
        DOT_DOAnchorPos testClass = new DOT_DOAnchorPos();
        bool result = testClass.CheckProperComponent(testObject);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void KeyframeTests_DORotate2D_Check()
    {
        // Setup
        GameObject testObject = Create2DTestObject();
        
        // Target
        DOT_DORotate_2D testClass = new DOT_DORotate_2D();
        bool result = testClass.CheckProperComponent(testObject);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void KeyframeTests_DOSizeDelta_Check()
    {
        // Setup
        GameObject testObject = Create2DTestObject();
        
        // Target
        DOT_DOSizeDelta testClass = new DOT_DOSizeDelta();
        bool result = testClass.CheckProperComponent(testObject);

        // Assert
        Assert.IsTrue(result);
    }
}

public class TweenReturns : KeyframeTests
{

    [Test]
    public void KeyframeTests_DOMove_Tween()
    {
        // Setup
        GameObject testObject = Create3DTestObject();
        DOT_DOMove testClass = new DOT_DOMove();
        
        // Target
        Tween test = testClass.GetAnimation(testObject);

        // Assert
        Assert.IsInstanceOf<Tween>(test);
    }

    [Test]
    public void KeyframeTests_DORotate_3D()
    {
        // Setup
        GameObject testObject = Create3DTestObject();
        DOT_DORotate_3D testClass = new DOT_DORotate_3D();
        
        // Target
        Tween test = testClass.GetAnimation(testObject);

        // Assert
        Assert.IsInstanceOf<Tween>(test);
    }

    [Test]
    public void KeyframeTests_DOScale()
    {
        // Setup
        GameObject testObject = Create3DTestObject();
        DOT_DOScale testClass = new DOT_DOScale();
        
        // Target
        Tween test = testClass.GetAnimation(testObject);

        // Assert
        Assert.IsInstanceOf<Tween>(test);
    }

    [Test]
    public void KeyframeTests_DOAnchorPos()
    {
        // Setup
        GameObject testObject = Create2DTestObject();
        DOT_DOAnchorPos testClass = new DOT_DOAnchorPos();
        
        // Target
        Tween test = testClass.GetAnimation(testObject);

        // Assert
        Assert.IsInstanceOf<Tween>(test);
    }

    [Test]
    public void KeyframeTests_DORotate_2D()
    {
        // Setup
        GameObject testObject = Create2DTestObject();
        DOT_DORotate_2D testClass = new DOT_DORotate_2D();
        
        // Target
        Tween test = testClass.GetAnimation(testObject);

        // Assert
        Assert.IsInstanceOf<Tween>(test);
    }


    [Test]
    public void KeyframeTests_DOSizeDelta()
    {
        // Setup
        GameObject testObject = Create2DTestObject();
        DOT_DOSizeDelta testClass = new DOT_DOSizeDelta();
        
        // Target
        Tween test = testClass.GetAnimation(testObject);

        // Assert
        Assert.IsInstanceOf<Tween>(test);
    }

}

    public GameObject Create3DTestObject()
    {
        GameObject testObject = new GameObject("Testing Object");
        testObject.tag = "UnitTests";

        return testObject;
    }

    public GameObject Create2DTestObject()
    {
        GameObject testObject = new GameObject("Testing Object", typeof(RectTransform));
        testObject.tag = "UnitTests";

        return testObject;
    }
}
