   M S B A M L   `   `   `  ����F  BMiniTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MiniTracker.ViewMiniTracker.View  5   	   $    MiniTracker.View.AddTaskWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MiniTracker.View     5   	   -   5        $��AddTaskwindow��5   	     � Title$  AddTaskWindow��5   	   $	��500��5	   	   $	��500��5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��70 �6   .+�5   
   �� $��0��6    �� Orientation$ Vertical=�5      $��Center=�5      $��Center=�5      $	��400��5      .+�5      �� $
��Bold"�6   $+��%Наименование задачи��5      �� 5      -   5        $��	NameBlock��5      $��Italic$�5      ��5      �� *
NameofTask+�� 5      �� 5      $
��Bold"�6   $#��Описание задачи��5      �� 5      -   5        $��DescriptionBlock��5      $��Italic$�5      ��5       �� *DescriptionofTask+5!      �� 5"   
   $��1��6   
�������
����  �$
��Bold"�5%      $
��18px(�5&      $#��Добавить задачу��5'      ��5(      �� *	AddTask+��5)      ��  �� ElementName$ AddTaskwindow��5*      5+      