   M S B A M L   `   `   `  ����N  JBNACTMFormGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:BNACTMFormGenerator.ViewsBNACTMFormGenerator.Views  5      M+clr-namespace:BNACTMFormGenerator.ViewModelBNACTMFormGenerator.ViewModel  5      A%clr-namespace:BNACTMFormGenerator.VMLBNACTMFormGenerator.VML  5      2    ,BNACTMFormGenerator.Views.AccionesATomarView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6vw'clr-namespace:BNACTMFormGenerator.Views     5      :vm+clr-namespace:BNACTMFormGenerator.ViewModel     5      5vml%clr-namespace:BNACTMFormGenerator.VML     5      .   (BNACTMFormGenerator.VML.ViewModelLocator    AutoHookedUpViewModel  . $	��650��5
      $	��550��6,    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $! ..\MainWindowResources.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $	��100 �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      $	��200 �6   �� 5$      �� 5%      $	��200 �6   .+�5(   
   �� $��0��6   $��0��6%   $��2��62   $P��JAcción a tomar si el job no inicia la ejecución a un horario determinado��6C   $��WrapWithOverflow=�6�   $
��Left=�6�   �� 5)   
   $��1��6   $��0��6&    �� Orientation$ 
Horizontal=�64   .+�5*      ��    
HorasArray#��[  5+      $��20��5,      $��40��5-      $	��Top=�5.      $��Right=�5/       / +ComboBoxToolTipWithErrorMessageOnErrorStyle#��[ 50       �� SelectedIndex 5*      �� *SelectedIndexHoraNoInicia+ �� Mode$ TwoWay=�	 �� ValidatesOnDataErrors	 . 
 �� NotifyOnValidationError
 .  �� UpdateSourceTrigger$ PropertyChanged=�50      �� 51      $	�� : ��6   $��12(�6#   $��25��61   $��10��6=   $	��Top=�6H   $��Right=�6`   �� 52        MinutosArray#��[ 53      $��20��54      $��40��55      $	��Top=�56      $��Right=�57      #��[ 58       52      �� *SelectedIndexMinutosNoInicia+$ TwoWay=�	 . 
 . $ PropertyChanged=�58      59      �� 5:   
   $��1��6   $��1��5;      $��2��5<      $��2��5=       �� TextWrapping$ WrapWithOverflow=�5?      $��40��5@      $	��250��5A      $	��Top=�5B      $
��Left=�5C       ' #ToolTipWithErrorMessageOnErrorStyle#��[ 5D      ��5>      �� *AvisoNoInicio+$ TwoWay=�	 . 
 . 5D      �� 5E   
   $��0��6   $��3��6%   $��2��62   $l��fAcción a tomar, si el job no finaliza a un horario estimado o luego de ejecutar un tiempo determinado��6C   $��WrapWithOverflow=�6�   $
��Left=�6�   �� 5F   
   $��1��6   $��3��5G      $��2��5H      $ WrapWithOverflow=�5J      $	��200��5K      $	��Top=�5L      $
��Left=�5M      #��[ 5N      ��5I      �� *TiempoJobNoFinaliza+$ TwoWay=�	 . 
 . 5N      �� 5O   
   $��1��6   $��4��5P      $��2��5Q      $��2��5R      $ WrapWithOverflow=�5T      $��40��5U      $	��250��5V      $	��Top=�5W      $
��Left=�5X      #��[ 5Y      ��5S      �� *AvisoJobNoFinaliza+$ TwoWay=�	 . 
 . 5Y      �� 5[   
   $��0��6   $��6��6$   $�� ��61   $
��Bold"�6:   �� 5\   
   $��0��6   $��7��6$   $��2��61   $6��0Acción a tomar en caso de una ejecucion exitosa��6E   $
��Bold"�6|   �� 5]   
   $��0��6   $��8��5^      $��2��5_      $��2��5`      $	��200��5c      $	��Top=�5d      ��5a      �� *AccionesExitosas+ �� SelectedItem 5b      �� *SelectedAccionExitosa+5d      � 5e   
   $��2��6   $��8��6   $��2��6,   $	��Top=�6=    5f      �� 5g      $��* �6#    5i      �� 5j      $��20 �6    �� 5k      $��20 �6    .+�5n      �� $��0��6   $��0��6%   $��Agregar Acción��62   $��80��6K   $
��Left=�6V   ��6q   �� *AddCommandAccionExitosa+�� 5o      $��1��6   $��1��6%   $��Borrar Acción��62   $��80��6J   $
��Left=�6U   ��6p   �� *DeleteCommandAccionExitosa+5p      �� 5r   
   $��0��6   $��10��6$   $��2��62   $1��+Acción a tomar en caso de una cancelación��6F   $
��Bold"�6w   �� 5s   
   $��0��6   $��11��5t      $��2��5u      $��2��5v      $	��200��5y      $	��Top=�5z      ��5w      �� *AccionesErroneas+ 5x      �� *SelectedAccionErronea+5z      � 5{   
   $��2��6   $��11��6   $	��Top=�6-   $��2��6E    5|      �� 5}      $��* �6#    5      �� 5�      $��20 �6    �� 5�      $��20 �6    .+�5�      �� $��0��6   $��0��6%   $��Agregar Acción��62   $��80��6K   $
��Left=�6V   ��6q   �� *AddCommandAccionErronea+�� 5�      $��1��6   $��1��6%   $��Borrar Acción��62   $��80��6J   $
��Left=�6U   ��6p   �� *DeleteCommandAccionErronea+5�      5�      5�      