using UnityEngine;
using UnityEngine.UIElements;

namespace UnityStudy.DesignPatterns.ModelViewViewModel
{
    public class HealthViewModel : MonoBehaviour
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
            SetDataBindings();
        }

        private void SetDataBindings()
        {
            var healthBar = m_Root.Q<ProgressBar>("health-bar");
            var healthBarProgress = healthBar?.Q<VisualElement>(className: "unity-progress-bar__progress");
            if (healthBarProgress == null) return;
            healthBarProgress.dataSource = m_HealthModelAsset;
            var binding = new DataBinding
            {
                dataSourcePath = new Unity.Properties.PropertyPath(nameof(HealthModel.CurrentHealth)),
                bindingMode = BindingMode.ToTarget,
            };
            binding.sourceToUiConverters.AddConverter((ref int value) =>
                new StyleColor(Color.Lerp(Color.red, Color.green, (float)value / m_HealthModelAsset.MaxHealth)));
            healthBarProgress.SetBinding("style.backgroundColor", binding);
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
