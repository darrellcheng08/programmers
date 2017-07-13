package sample;

import javafx.animation.TranslateTransition;
import javafx.event.ActionEvent;
import javafx.fxml.Initializable;
import javafx.scene.layout.VBox;

import java.net.URL;
import java.util.ResourceBundle;

public class Controller implements Initializable {

    public VBox drawer;

    @Override
    public void initialize(URL location, ResourceBundle resources) {
    }

    public void hide(ActionEvent actionEvent) {
        TranslateTransition t = new TranslateTransition();
        t.setNode(drawer);
        t.setToX(-drawer.getWidth());
        t.play();
    }

    public void show(ActionEvent actionEvent) {
        TranslateTransition t = new TranslateTransition();
        t.setNode(drawer);
        t.setToX(0.0);
        t.play();
    }
}
