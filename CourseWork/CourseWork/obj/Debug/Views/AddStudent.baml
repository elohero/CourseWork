   M S B A M L   `   `   `  ����E  ACourseWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseWork.ViewsCourseWork.Views  5   	   !    CourseWork.Views.AddStudent   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CourseWork.Views     5   	   h dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak	 gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae
 aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a^  ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am! iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag" cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj# fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ay	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks     	 
                        ! " # 66   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��380��6)    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��2* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    .+�5      ��  �� CornerRadius$ 10��6   $��4��6'   ��5      �� 5      .��5      �  � Color$ #7BE9F6��6'    � Offset$	 0.0Q�67   � 5      $ #F083DA��6'   $ 1Q�67   5      5      �� 5      $��1��6   $��0,0,0,0q�6'   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5       �� -   5        	 ��Name$	 AddressTextBox��5.      $��	Helvetica)�5       $��Light"�5!      $��Address��5"      $��20(�5#      $��Center=�5$      
�������
������ $��0q�5'      $	��235��5(      $
��Left=�5)      
 J� Opacity$	
 0.5Q�5*      $��25��5+      $��63,0,0,0q�5,      5.      5/      �� 51      $	��250��6   $��2��52      
�������$	
 0.5Q�54      �� 56      $ 
Horizontal=�6   $��0,20,0,0q�67   .+�57      �� -   5        $	 PhoneTextBox��5E      $��	Helvetica)�57      $��Light"�58      $��Phone��59      $��20(�5:      $��Center=�5;      
�������
������ $��0q�5>      $	��235��5?      $
��Left=�5@      $	
 0.5Q�5A      $��25��5B      $��63,0,0,0q�5C      5E      5F      �� 5H      $	��250��6   $��2��5I      
�������$	
 0.5Q�5K      5L      �� 5N      $��2��6   .+�5O      �� $ 
Horizontal=�6   .+�5P      �� -   5        $	 ParrentFullNameTextBox��5^      $��	Helvetica)�5P      $��Light"�5Q      $��ParrentFullName��5R      $��20(�5S      $��Center=�5T      
�������
������ $��0q�5W      $	��235��5X      $
��Left=�5Y      $	
 0.5Q�5Z      $��25��5[      $��63,0,0,0q�5\      5^      5_      �� 5a      $	��250��6   $��2��5b      
�������$	
 0.5Q�5d      �� 5f      $ 
Horizontal=�6   .+�5g      �� -   5        $	 IsLivingInObchagaTextBox��5u      $��	Helvetica)�5g      $��Light"�5h      $��IsLivingInObchaga��5i      $��20(�5j      $��Center=�5k      
�������
������ $��0q�5n      $	��235��5o      $
��Left=�5p      $	
 0.5Q�5q      $��25��5r      $��63,0,0,0q�5s      5u      5v      �� 5x      $	��250��6   $��2��5y      
�������$	
 0.5Q�5{      5~      �� 5      $��3��6   $ 
Horizontal=�6&   $��0,0,0,0q�6?   .+�5�      �� -   5        $	��100��5�   2   $��40��6>   $��REGISTER��6J   5�      5�      5�      5�      