using UnityEngine;
using UnityEngine.UIElements;
using UnityStudy.DesignPatterns.ModelViewPresenter;

namespace UnityStudy.DesignPatterns
{
    public class HealthPresenter : MonoBehaviour
    {
        [SerializeField] private UIDocument m_Document;
        [SerializeField] private HealthModel m_HealthModelAsset;
        private VisualElement m_Root;
        private ProgressBar m_HealthBar;
        private Label m_StatusLabel;
        private Label m_ValueLabel;

        private void OnEnable()
        {
            m_Root = m_Document.rootVisualElement;

            if(m_HealthModelAsset != null)
            {
                m_HealthModelAsset.HealthChanged += OnHealthChanged;
                UpdateUI();
            }
        }

        private void OnHealthChanged() => UpdateUI();

        private void OnDisable()
        {
            if(m_HealthModelAsset != null)
                m_HealthModelAsset.HealthChanged -= OnHealthChanged;
        }

        private void UpdateUI()
        {
            // Logic to update UI elements based on the health model data
            float healthPercentage = (float)m_HealthModelAsset.CurrentHealth / m_HealthModelAsset.MaxHealth;

            // Update the progress bar to reflect the current health
            m_HealthBar.value = healthPercentage * 100;

            // Change the color of the health bar based on health percentage
            m_HealthBar.Q<VisualElement>("progress").style.backgroundColor = 
                new StyleColor(Color.Lerp(Color.red, Color.green, healthPercentage));

            // Update the status label based on the health percentage
            m_StatusLabel.text = healthPercentage switch
            {
                < 0.33f => "Danger",
                < 0.66f => "Neutral",
                _ => "Good"
            };

            // Update the numerical value label
            m_ValueLabel.text = m_HealthModelAsset.CurrentHealth.ToString();
        }

        private void RegisterElement()
        {
            var resetButton = m_Root.Q<Button>("reset-button");
            if (resetButton != null)
                resetButton.clicked += RestoreHealth;
        }

        public void RestoreHealth() => m_HealthModelAsset.Restore();
        public void ApplyDamage(int damage) => m_HealthModelAsset.Decrement(damage);
    }

}
