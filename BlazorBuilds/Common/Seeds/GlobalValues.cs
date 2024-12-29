namespace BlazorBuilds.Common.Seeds;

public static class GlobalValues
{

    public const string Background_Prefix                = "bg";
    public const int Shade_Percent_Increments_10         = 10;
    public const int Trans_Precent_Increments_5          = 5;
    public const int Text_Light_Mix_Percent_90           = 90;
    public const int Text_Dark_Mix_Percent_80            = 80;
    public const int Canvas_Light_Mix_Percent_95         = 95;
    public const int Canvas_Dark_Mix_Percent_65          = 65;
    public const int Canvas_Dark_Mix_Percent_85          = 85;


    public const string Primary_Colour_Name              = "Primary";
    public const string Primary_Shade_Class_Lighter_Name = "primary-bg-lighter";
    public const string Primary_Shade_Class_Darker_Name  = "primary-bg-darker";
    public const string Primary_Canvas_Dark_Var_Name     = "--canvas-primary-dark";
    public const string Primary_Canvas_Light_Var_Name    = "--canvas-primary-light";
    public const string Primary_Text_Light_Var_Name      = "--text-primary-light";
    public const string Primary_Text_Dark_Var_Name       = "--text-primary-dark";
    public const string Primary_Trans_Class_Name         = "primary-bg-trans";
                                                         
    public const string Accent_Colour_Name               = "Accent";
    public const string Accent_Shade_Class_Lighter_Name  = "accent-bg-lighter";
    public const string Accent_Shade_Class_Darker_Name   = "accent-bg-darker";
    public const string Accent_Canvas_Dark_Var_Name      = "--canvas-accent-dark";
    public const string Accent_Canvas_Light_Var_Name     = "--canvas-accent-light";
    public const string Accent_Text_Light_Var_Name       = "--text-accent-light";
    public const string Accent_Text_Dark_Var_Name        = "--text-accent-dark";
    public const string Accent_Trans_Class_Name          = "accent-bg-trans";

    public const string Neutral_Colour_Name              = "Neutral";
    public const string Neutral_Shade_Class_Lighter_Name = "neutral-bg-lighter";
    public const string Neutral_Shade_Class_Darker_Name  = "neutral-bg-darker";
    public const string Neutral_Canvas_Dark_Var_Name     = "--canvas-neutral-dark";
    public const string Neutral_Canvas_Light_Var_Name    = "--canvas-neutral-light";
    public const string Neutral_Text_Light_Var_Name      = "--text-neutral-light";
    public const string Neutral_Text_Dark_Var_Name       = "--text-neutral-dark";
    public const string Neutral_Trans_Class_Name         = "neutral-bg-trans";

    public const string Danger_Colour_Name               = "Danger";
    public const string Danger_Shade_Class_Lighter_Name  = "danger-bg-lighter";
    public const string Danger_Shade_Class_Darker_Name   = "danger-bg-darker";
    public const string Danger_Canvas_Dark_Var_Name      = "--canvas-danger-dark";
    public const string Danger_Canvas_Light_Var_Name     = "--canvas-danger-light";
    public const string Danger_Text_Light_Var_Name       = "--text-danger-light";
    public const string Danger_Text_Dark_Var_Name        = "--text-danger-dark";
    public const string Danger_Trans_Class_Name          = "danger-bg-trans";
    
    public const string Warning_Colour_Name              = "Warning";
    public const string Warning_Shade_Class_Lighter_Name = "warning-bg-lighter";
    public const string Warning_Shade_Class_Darker_Name  = "warning-bg-darker";
    public const string Warning_Canvas_Dark_Var_Name     = "--canvas-warning-dark";
    public const string Warning_Canvas_Light_Var_Name    = "--canvas-warning-light";
    public const string Warning_Text_Light_Var_Name      = "--text-warning-light";
    public const string Warning_Text_Dark_Var_Name       = "--text-warning-dark";
    public const string Warning_Trans_Class_Name         = "warning-bg-trans";
    
    
    public const string Success_Colour_Name              = "Success";
    public const string Success_Shade_Class_Lighter_Name = "success-bg-lighter";
    public const string Success_Shade_Class_Darker_Name  = "success-bg-darker";
    public const string Success_Canvas_Dark_Var_Name     = "--canvas-success-dark";
    public const string Success_Canvas_Light_Var_Name    = "--canvas-success-light";
    public const string Success_Text_Light_Var_Name      = "--text-success-light";
    public const string Success_Text_Dark_Var_Name       = "--text-success-dark";
    public const string Success_Trans_Class_Name         = "success-bg-trans";
    
    public const string Info_Colour_Name                 = "Info";
    public const string Info_Shade_Class_Lighter_Name    = "info-bg-lighter";
    public const string Info_Shade_Class_Darker_Name     = "info-bg-darker";
    public const string Info_Canvas_Dark_Var_Name        = "--canvas-info-dark";
    public const string Info_Canvas_Light_Var_Name       = "--canvas-info-light";
    public const string Info_Text_Light_Var_Name         = "--text-info-light";
    public const string Info_Text_Dark_Var_Name          = "--text-info-dark";
    public const string Info_Trans_Class_Name            = "info-bg-trans";


    public const string Small_Prefix                     = "sm";

    public const string Font_Label_Class                 = "fs-label";
    public const string Font_Size_Text                   = "The five boxing wizards jump quickly";
    public const string Font_Weight_Prefix               = "fw";
    public const string Font_Size_Prefix                 = "fs";
    public const int    Small_Font_Size_Count            = 3;
    public const int    Font_Size_Count                  = 9;
    public const double Font_Scale_Factor                = 1.25;//double to match sass

    public const int Font_Weight_Count                   = 9;
    public const int Font_Weight_Factor                  = 100;

    public const string Style_As_Dark                    = "dark";
    public const string Style_As_Light                   = "light";

    #region Used by the Contrast Checker

    public const string Incorrect_Hex_Value_Exception_Message = "Invalid hex value. The value should only contain a-f, A-F and 0-9 characters, optionally starting with the pound # symbol";
    public const string Invalid_Colour_Entry_Message          = "Invalid hex colour value. Please use the full format of a pound sign followed by six characters, each being A to F or 0 to 9";
    public const string Aria_MaxLength_Reached_Message        = "That key was not used as the maximum length of the input has been reached.";
    public const string Aria_Format_Contrast_Ratio_Message    = "Contrast ratio {0} to 1";  
    public const string Regex_Hex_Colour_Pattern              = "^#?[a-fA-F0-9]{6}$";
    public const string Regex_Colour_Key_Pattern              = "^[#a-fA-F0-9]$";
    public const string Regex_Hex_Replace_Pattern             = "[^a-fA-F0-9]";
    public const string Icon_Pass_Modifier_Class              = "contrast-checker__icon--pass";
    public const string Icon_Fail_Modifier_Class              = "contrast-checker__icon--fail";
    public const string Contrast_Ratio_Pass_Text              = "Passed";
    public const string Contrast_Ratio_Fail_Text              = "Failed";

    public const double Min_AAA_Normal_Text_Ratio = 7;
    public const double Min_AAA_Large_Text_Ratio  = 4.5;
    public const double Min_AA_Normal_Text_Ratio  = 4.5;
    public const double Min_AA_Large_Text_Ratio   = 3;
    public const double Min_Borders_Ratio         = 3;
    public const double Regular_Font_PX           = 16;
    public const double Large_Font_Bold_PX        = 18.66;
    public const double Large_Font_PX             = 24;


    #endregion

}

