   M S B A M L   `   `   `  ����F  BMiniTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MiniTracker.ViewMiniTracker.View  5   	   %    MiniTracker.View.EditTaskWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MiniTracker.View     5   	   -   5        $��EditTaskwindow��5   	     � Title$  EditTaskWindow��5   	   $	��500��5	   	   $	��500��5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��70 �6   .+�5   
   �� $��0��6    �� Orientation$ Vertical=�5      $��Center=�5      $��Center=�5      $	��400��5      .+�5      �� $
��Bold"�6   $+��%Наименование задачи��5      �� 5      $��Italic$�6   ��5      �� *
NameofTask+�� 5      �� 5      $
��Bold"�6   $#��Описание задачи��5      �� 5      $��Italic$�6   ��5      �� *DescriptionofTask+5      �� 5    
   $��1��6   
�������
��� ���$
��Bold"�5#      $
��18px(�5$      $-��'Редактировать задачу��5%      ��5&      �� *
EditTask+��5'      ��  �� ElementName$ EditTaskwindow��5(      5)      